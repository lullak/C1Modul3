using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Classes
{
    class FileHandler
    {
        private string _filePath {  get; set; }

        public FileHandler(string filePath)
        {
            _filePath = filePath;
        }

        public void CreateFile() 
        {
            if (!File.Exists(_filePath))
            {
                using (FileStream fs = File.Create(_filePath)) { }
            }
        }

        public void WriteToFile(string text)
        {
            CreateFile();
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine(text);
            }
        }
    }
}
