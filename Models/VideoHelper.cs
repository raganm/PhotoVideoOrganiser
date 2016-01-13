using System;
using System.IO;

namespace Models
{
    public class VideoHelper : IGetNewNames
    {
        private string _outputDirectory;

        public string GetOrganisedFileName(string path, string outputDirectory)
        {
            _outputDirectory = outputDirectory;

            var newName = GenerateNewName(path);

            var destinationDirectory = GenerateDestinationDirectory(path);

            var destination = Path.Combine(destinationDirectory, newName);

            return destination;
        }

        private string GenerateNewName(string path)
        {
            var fi = new FileInfo(path);
            var dateTaken = GetDateTimeTaken(path);
            var size = fi.Length;
            string newName;
            try
            {
                newName = string.Format("{2} - {0}{1}", size, fi.Extension, dateTaken.ToString("yyyy-MM-dd HH.mm.ss"));
            }
            catch (Exception)
            {
                newName = string.Format("Unable to get date time information {2} - {0}{1}", size, fi.Extension, Guid.NewGuid().ToString());
            }

            return newName.ToLower();
        }

        public DateTime GetDateTimeTaken(string path)
        {
            var fi = new FileInfo(path);

            return fi.LastWriteTime;
        }

        private string GenerateDestinationDirectory(string path)
        {
            string fullPath;

            try
            {
                var dateTaken = GetDateTimeTaken(path);
                fullPath = Path.Combine(_outputDirectory, "Videos - Home", dateTaken.Year.ToString(), dateTaken.ToString("yyyy MM MMMMM"));
            }
            catch (Exception)
            {
                fullPath = Path.Combine(_outputDirectory, "Videos - Home", "Missing Date Time");
            }

            return fullPath;
        }
    }
}
