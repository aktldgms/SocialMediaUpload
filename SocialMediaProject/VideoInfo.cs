using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaProject
{
    internal class VideoInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
        public string Category { get; set; }
        public string Privacy { get; set; }
        public string FilePath { get; set; }
        public string ThumbnailPath { get; set; }
        public string client_secretsPath { get; set; }
    }
}
