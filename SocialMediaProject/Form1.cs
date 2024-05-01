using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaProject
{
    public partial class Form1 : Form
    {
        private Categories categories; 
        string result;
        string id = "0";
        AllCategories categoriesData;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            filePath.Text = ""; // Default dosya yolu (video)
            thumbnailPath.Text = ""; // Default dosya yolu (thumbnail)
            csPath.Text = ""; // Default dosya yolu (client_secret)
        }

        private async void LoadData()
        {
            try
            {
                categories = new Categories();
                result = await categories.GetVideoCategories();
                categoriesData = JsonConvert.DeserializeObject<AllCategories>(result);

                foreach (var item in categoriesData.items)
                {
                    if (item.snippet.assignable)
                    {
                        category.Items.Add(item.snippet.title);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private async void submit_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = new VideoInfo
            {
                Title = title.Text,
                Description = description.Text,
                Tags = tags.Text.Split(' ', '\t', ',', '.', ':', ';'),
                Category = id,
                Privacy = privacy.SelectedItem.ToString(),
                FilePath = filePath.Text,
                ThumbnailPath = thumbnailPath.Text,
                client_secretsPath = csPath.Text
            };

            try
            {
                await YoutubeSide.Run(videoInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void araF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Dosya Seç";
                openFileDialog.Filter = "Video Dosyalarý|*.mp4";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void araT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Dosya Seç";
                openFileDialog.Filter = "Resim Dosyalarý|*.png;*.jpg;*.jpeg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    thumbnailPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void araCS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Dosya Seç";
                openFileDialog.Filter = "KeyValue|*.json";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    csPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoriesData.items.ForEach(item => { 
                if(item.snippet.title == category.SelectedItem.ToString())
                {
                    id = item.id;
                }
            });
        }
    }

}
