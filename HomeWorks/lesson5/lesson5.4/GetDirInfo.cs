using System;
using System.IO;

namespace lesson5._4
{
    public class GetDirInfo
    {
        private static string _path = null;

        public GetDirInfo(string path)
        {
            _path = path;
        }
        
        public static void Recursive()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(_path);
            RecursiveSearch.Recursive(dirInfo);
        }
        public static void NotRecursive()
        {
            var files = Directory.GetFiles(_path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine($"{file}");
            }
            File.AppendAllLines("rootInfo.txt", files);
        }
    }
}