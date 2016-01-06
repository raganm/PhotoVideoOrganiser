using System;
using System.Collections.Generic;
using System.IO;

namespace PhotoOrganiser
{
    public class Organiser
    {
        private readonly Renamer _renamer;
        private readonly string _outputDirectory;

        public Organiser(string outputDirectory, Renamer renamer)
        {
            _outputDirectory = outputDirectory;
            _renamer = renamer;
        }
        public Organiser(string outputDirectory)
        {
            _outputDirectory = outputDirectory;
            _renamer = new Renamer();
        }

        public void OrganiseFile(string path)
        {
            var renamedFile = _renamer.Rename(path, false);

            FilePhoto(renamedFile);
        }

        public List<PhotoAnalysis> OrganiseDirectory(string sourceDirectory, bool organiseSubDirectories, bool analyseOnly, string extension)
        {
            var searchOption = organiseSubDirectories
                ? SearchOption.AllDirectories
                : SearchOption.TopDirectoryOnly;



            var fileEntries = Directory.GetFiles(sourceDirectory, extension, searchOption);

            var files = new List<PhotoAnalysis>();

            foreach (string file in fileEntries)
            {
                string newName;

                if (analyseOnly)
                {
                    newName = _renamer.Rename(file, true);
                }
                else
                {
                    newName = _renamer.Rename(file,false);

                    FilePhoto(newName);
                }

                var fi = new FileInfo(file);
                var fi2 = new FileInfo(newName);
                var photoAnalysis = new PhotoAnalysis
                {
                    OriginalName = fi.Name,
                    NewName = fi2.Name
                };

                files.Add(photoAnalysis);
            }

            return files;
        }

        private void FilePhoto(string path)
        {
            var fi = new FileInfo(path);

            var destinationDirectory = GenerateDestinationDirectory(path);

            CreateDestinationDirectory(destinationDirectory);

            var organisedFile = Path.Combine(destinationDirectory, fi.Name);

            if (!File.Exists(organisedFile))
            {
                File.Move(path, organisedFile);
            }
        }

        private string GenerateDestinationDirectory(string path)
        {
            var nameGenerator = new NameGenerator();

            string fullPath;

            try
            {
                var dateTaken = nameGenerator.GetDateTimeTaken(path);
                fullPath = Path.Combine(_outputDirectory, dateTaken.Year.ToString(), dateTaken.ToString("yyyy MM MMMMM"));

            }
            catch (Exception)
            {
                fullPath = Path.Combine(_outputDirectory, "Missing Date Time");
            }

            return fullPath;
        }

        public void CreateDestinationDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
