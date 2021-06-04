using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsolePDFCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read from the class Singleton the data of the addresses
            if (Directory.Exists(Singleton.Instance.FileIn) && Directory.Exists(Singleton.Instance.FileOut))
            {
                //Continius with the project and write the susccessful process in the log
            }
            else
            {
                //Close the project and write the erros process in the Log
            }
            //Varieble of control
            string[] XMLData = new string[13];
            //infiniye While for the reading
            while (true)
            {
                //Get list of the documents in the directory 
                string[] ListFiles = System.IO.Directory.GetFiles(Singleton.Instance.FileIn);
                //Get the number of the documentes 
                int NumberFileList = ListFiles.Length;
                
                if (NumberFileList != 0)
                {
                    //Continius with the prject
                    foreach (var itemFile in ListFiles)
                    {
                        string FileName = Path.GetFileName(itemFile);
                        XMLData = XMLReader.Reader(itemFile);
                        PDFCreator.DataRecive(XMLData, FileName);
                        File.Move(Singleton.Instance.FileIn + FileName, Singleton.Instance.FileOut + FileName);
                    }
                }
                else
                {
                    //Wait for the documetnes in the directory "In"
                }

            }
        }
    }
}
