using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;

namespace stream.infrastructure
{
    class IsolatedStorageStreamExamples
    {
        public void Create()
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetMachineStoreForAssembly();


            var t = new IsolatedStorageFileStream("myfile.txt", FileMode.Create, isf);


        }
    }
}
