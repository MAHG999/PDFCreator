using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsolePDFCreator
{
    class Singleton
    {
        private static Singleton instance = null;

        //Declarate a variables for to read the file App.config
        public string FileIn = null;
        public string FileOut = null;


        protected Singleton()
        {
            //Loading the data of the App.config
            FileIn = ConfigurationManager.AppSettings["In"];
            FileOut = ConfigurationManager.AppSettings["Out"];
        }

        public static Singleton Instance
        {
            //Return a verification of de data
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
