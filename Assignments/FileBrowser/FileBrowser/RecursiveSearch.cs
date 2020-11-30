using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace FileBrowser
{
    class RecursiveSearch
    {

        // Process all files in the directory passed in, recurse on any directories
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            try
            {
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                    ProcessFile(fileName);
            }
            catch(System.UnauthorizedAccessException)
            {
                
            }
            

            // Recurse into subdirectories of this directory.
            try
            {
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
               
                    ProcessDirectory(subdirectory);
            }
            catch(System.UnauthorizedAccessException)
            {
                
            }
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", Path.GetFileName(path));
        }
    }
}
