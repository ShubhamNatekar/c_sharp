using System;

namespace Interface
{
    interface IFile
    {
        void ReadFile();
    }

    interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile();
    }
    //Multiple Interfacess
    class FileInfo : IFile, IBinaryFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading Text File");
        }

        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Opening Binary File");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading Binary File");
        }

        public void Search(string text)
        {
            Console.WriteLine("Searching in File");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFile file1 = new FileInfo();
            IBinaryFile file2 = new FileInfo();
            FileInfo file3 = new FileInfo();
            
            file1.ReadFile(); 
            //file1.OpenBinaryFile(); //compile-time error 
            //file1.SearchFile("text to be searched"); //compile-time error 
            
            file2.OpenBinaryFile();
            file2.ReadFile();
            //file2.SearchFile("text to be searched"); //compile-time error 
        
            file3.Search("text to be searched");
            //file3.ReadFile(); //compile-time error 
            //file3.OpenBinaryFile(); //compile-time error  
        }
    }
}
