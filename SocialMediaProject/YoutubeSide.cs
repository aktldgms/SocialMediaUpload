using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.YouTube.v3;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaProject
{
    internal class YoutubeSide
    {
        private static YouTubeService youtubeService;
        private static Video video;

        [Obsolete]
        public static async Task Run(VideoInfo videoInfo)
        {
            try
            {
                UserCredential credential;
                using (var stream = new FileStream(videoInfo.client_secretsPath, FileMode.Open, FileAccess.Read))
                {
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        new[] { YouTubeService.Scope.YoutubeUpload },
                        "user",
                        CancellationToken.None
                    );
                }

                youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
                });

                video = new Video();
                video.Snippet = new VideoSnippet();
                video.Snippet.Title = videoInfo.Title;
                video.Snippet.Description = videoInfo.Description;
                video.Snippet.Tags = videoInfo.Tags;
                video.Snippet.CategoryId = videoInfo.Category;
                video.Status = new VideoStatus();
                video.Status.PrivacyStatus = videoInfo.Privacy;
                video.Status.SelfDeclaredMadeForKids = false;

                var thumbnailDetails = new ThumbnailDetails();

                var defaultThumbnail = new Thumbnail();
                defaultThumbnail.Url = videoInfo.ThumbnailPath;

                thumbnailDetails.Default__ = defaultThumbnail;

                video.Snippet.Thumbnails = thumbnailDetails;

                using (var fileStream = new FileStream(videoInfo.FilePath, FileMode.Open))
                {
                    var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                    videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                    videosInsertRequest.ResponseReceived += async (v) =>
                    {
                        MessageBox.Show($"Video id '{v.Id}' was successfully uploaded.");

                        await SetThumbnail(v.Id, videoInfo.ThumbnailPath);
                    };

                    await videosInsertRequest.UploadAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        public static async Task SetThumbnail(string videoId, string thumbnailPath)
        {
            using (var fileStream = new FileStream(thumbnailPath, FileMode.Open))
            {
                var setThumbnailRequest = youtubeService.Thumbnails.Set(videoId, fileStream, "image/jpeg");
                setThumbnailRequest.ProgressChanged += setThumbnailRequest_ProgressChanged;
                setThumbnailRequest.ResponseReceived += setThumbnailRequest_ResponseReceived;

                await setThumbnailRequest.UploadAsync();
            }
        }

        private static void videosInsertRequest_ProgressChanged(IUploadProgress progress)
        {
            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    MessageBox.Show($"{progress.BytesSent} bytes sent.");
                    break;

                case UploadStatus.Failed:
                    MessageBox.Show($"An error prevented the upload from completing.\n{progress.Exception}");
                    break;
            }
        }

        private static void videosInsertRequest_ResponseReceived(Video video)
        {
            MessageBox.Show($"Video id '{video.Id}' was successfully uploaded.");
        }

        private static void setThumbnailRequest_ProgressChanged(IUploadProgress progress)
        {
            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    MessageBox.Show($"{progress.BytesSent} bytes sent for thumbnail.");
                    break;

                case UploadStatus.Failed:
                    MessageBox.Show($"An error prevented the thumbnail upload from completing.\n{progress.Exception}");
                    break;
            }
        }

        private static void setThumbnailRequest_ResponseReceived(ThumbnailSetResponse thumbnailSetResponse)
        {
            MessageBox.Show($"Thumbnail set successfully.");
        }
    }
}
