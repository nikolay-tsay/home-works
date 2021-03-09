using System;
using System.IO;


namespace lesson5._4
{
    public static class RecursiveSearch
    {
        private static FileInfo[] _files = null;
        private static DirectoryInfo[] _subDirs = null;

        static RecursiveSearch()
        {

        }

        public static void Recursive(DirectoryInfo root)
        {
            try
            {
                _files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (_files != null)
            {
                foreach (FileInfo file in _files)
                {
                    Console.WriteLine(file.FullName);
                    File.AppendAllText("rootInfo.txt", $"{file.FullName}\n");
                }

                _subDirs = root.GetDirectories();
                foreach (DirectoryInfo dirInfo in _subDirs)
                {
                    Recursive(dirInfo);
                }
            }
        }
    }
}   