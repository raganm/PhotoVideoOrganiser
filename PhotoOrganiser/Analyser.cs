using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoOrganiser
{
    public class Analyser
    {
        public void AnalyseDirectory(string path)
        {
            var di = new DirectoryInfo(path);
            ProcessDirectory(di.FullName);
        }

        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory,"*.jpg");
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            var sut = new NameGenerator();
            
            var newName = sut.GenerateNewName(path);

            var fi = new FileInfo(path);

            if (!string.Equals(fi.Name, newName, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("{0} didnt match {1}", fi.Name.ToLower(), newName.ToLower());
            }

        }
    }
}
