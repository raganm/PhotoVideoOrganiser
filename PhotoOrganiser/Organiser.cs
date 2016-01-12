using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Models;
using File = System.IO.File;

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

        public List<Models.File> OrganiseDirectory(string sourceDirectory, bool organiseSubDirectories, bool renameFiles, bool organiseFiles, string extension)
        {
            var searchOption = organiseSubDirectories
                ? SearchOption.AllDirectories
                : SearchOption.TopDirectoryOnly;

            if (!Directory.Exists(sourceDirectory))
            {
                return new List<Models.File>();
            }

            var fileEntries = Directory.GetFiles(sourceDirectory, extension, searchOption);

            var files = new List<Models.File>();

            foreach (var file in fileEntries)
            {
                var newName = _renamer.Rename(file, false);

                if (renameFiles)
                {
                    newName = _renamer.Rename(file, true);
                }

                if (organiseFiles)
                {
                    FilePhoto(newName);
                }

                var fi = new FileInfo(file);
                var fi2 = new FileInfo(newName);
                var photoAnalysis = new Models.File
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
                fullPath = Path.Combine( _outputDirectory,"Photos", dateTaken.Year.ToString(), dateTaken.ToString("yyyy MM MMMMM"));

            }
            catch (Exception)
            {
                fullPath = Path.Combine(_outputDirectory, "Photos","Missing Date Time");
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
