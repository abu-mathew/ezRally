using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzRally
{
    public class FileManager
    {
        public StreamReader ReadFile(string FilePath)
        {
            FileStream fs = File.OpenRead(FilePath);
            StreamReader reader = new StreamReader(fs);
            return reader;
        }

        public void WriteFile(string FilePath, string FileContent)
        {

        }

        public bool CheckFileExistance(string[] FileCollection)
        {
            bool status = false;
            foreach (string path in FileCollection)
            {
                if(!File.Exists(path))
                {
                    status = false;
                }
            }

            return status;
        }
    }
}
