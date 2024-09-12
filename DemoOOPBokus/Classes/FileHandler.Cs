using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOPBokus.Classes
{
    public class FileHandler
    {
        private string _filePath;
        public FileHandler(string filePath)
        {
            _filePath = filePath;
        }
        public void WriteToFile(string text)
        {

            using (StreamWriter writer = new StreamWriter(_filePath, true)) 
            {
                writer.WriteLine(text);
            }
            //using (FileStream FileStream = new FileStream(_filePath))
            //{
            //}

        }
    }
}
