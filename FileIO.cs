using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiative_Tracker
{
    class FileIO
    {
        private const string dir = "C:/data/";                          // I'm hogging the C Drive, but it suits my purpose.
        private const string file = "default.txt";                      // Default player list ((obviously))

        public void checkForFile()
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string path = dir + file;                                   // "C:/data/default.txt"

            if (!File.Exists(path))
            {
                using (StreamWriter w = File.CreateText(path))          // Automatically sorted so I don't have to code it
                {
                    w.WriteLine("Danielle");
                    w.WriteLine("Derek");
                    w.WriteLine("Gary");
                    w.WriteLine("Jerimey");
                    w.WriteLine("Joey");
                    w.WriteLine("John");
                    w.WriteLine("Mike");
                }
            }

        }
    }
}
