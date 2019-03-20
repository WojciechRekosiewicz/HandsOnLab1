using System.Collections.Generic;
using System.IO;

namespace HandsOnLab1.ServiceAgents
{
    public class ImageAgent
    {
        public static List<string> GetImages()
        {
            List<string> images = new List<string>();
            LoadImages(GetImageRoot(), images);
            return images;
        }

        private static string GetImageRoot()
        {
            return Directory.GetCurrentDirectory();
        }

        private static void LoadImages(string folderLocation, IList<string> images)
        {
            string[] files = Directory.GetFiles(folderLocation);
            foreach (string file in files)
            {
                if (IsImage(file))
                {
                    images.Add(file);
                }
            }
            string[] folders = Directory.GetDirectories(folderLocation);
            foreach (string folder in folders)
            {
                LoadImages(folder, images);
            }
        }

        private static bool IsImage(string file)
        {
            string extension = file.ToLower().Substring(file.Length - 4);
            switch (extension)
            {
                case ".bmp":
                case ".gif":
                case ".jpg":
                case ".png":
                    return true;
                default:
                    return false;
            }
        }
    }
}
