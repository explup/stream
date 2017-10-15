using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace stream.infrastructure
{
    class FileStreamExamples
    {
        public void CreateFileStreamExamples()
        {
            //absolute path
            string path = @"c:\myfiles\data.txt";
            //relative path based on application running directory
           
            FileStream fs = File.OpenRead(path);

            FileStream fs1 = File.OpenWrite(path);

            FileStream fs2 = File.Create(path);

            FileStream fs3 = new FileStream(path, FileMode.Create);

            //file sahre
            FileStream fs4 = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);


            //File security
        }
    }
}
