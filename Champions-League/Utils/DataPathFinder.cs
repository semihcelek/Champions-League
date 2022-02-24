using System;
using System.IO;

namespace SemihCelek.Champions_League.Utils
{
    public class DataPathFinder : IDataPathFinder
    {
        private readonly string _projectDirectory;

        public DataPathFinder()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

            _projectDirectory = projectDirectory;
        }

        public string GetDataPath(string fileName)
        {
            return $"{_projectDirectory}/Datas/{fileName}";
        }
    }
}