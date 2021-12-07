//FileRoot.cs, Chase Walton
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextManipulator
{
    class FileRoot
    {
        public static string RootPath()
        {
            string rootDirectory = System.IO.Directory.GetCurrentDirectory();           
            rootDirectory = rootDirectory.Substring(0, rootDirectory.IndexOf("bin"));   
            return rootDirectory;
        }

        public static string FilePath()
        {
            string[] files = Directory.GetFiles(RootPath(), "rootFile1.txt");       //Using our root directory from the RootPath() method find the file named 'rootFile1.txt.'
            return files[0];  //Return the path of this file.           
        }
        
    }
}
