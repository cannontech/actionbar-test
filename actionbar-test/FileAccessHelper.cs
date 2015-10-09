using System;

namespace actionbartest
{
    public class FileAccessHelper
    {
        public FileAccessHelper()
        {
        }

        public static string GetLocalFilePath(string filename)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, filename);
        }
    }
}

