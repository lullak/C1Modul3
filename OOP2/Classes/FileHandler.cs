using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Classes
{
    public class FileHandler
    {
        private string _filePath {  get; set; }

        public FileHandler(string filePath)
        {
            _filePath = filePath;
        }


        public void WriteToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine(text);
            }
        }
    }
}
