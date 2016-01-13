using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using File = System.IO.File;

namespace VideoOrganiser
{
    public class Organiser
    {
        private readonly string _outputDirectory;

        public Organiser(string outputDirectory)
        {
            _outputDirectory = outputDirectory;
            _renamer = new Renamer();
        }

        public List<FileAnalysis> OrganiseDirectory(string sourceDirectory, Options options, string extension)
        {
            var searchOption = options.organiseSubDirectories
                ? SearchOption.AllDirectories
                : SearchOption.TopDirectoryOnly;

            if (!Directory.Exists(sourceDirectory))
            {
                return new List<FileAnalysis>();
            }

            var fileEntries = Directory.GetFiles(sourceDirectory, extension, searchOption);

            var files = new List<FileAnalysis>();

            foreach (var filePath in fileEntries)
            {
                var file = new FileAnalysis(filePath, _outputDirectory);

                if (options.renameFiles)
                {
                    if (!file.DoesCorrectlyNamedFileExist)
                    {
                        File.Move(file.CurrentFullName, file.CorrectFullName);
                    }
                }

                if (options.organiseFiles)
                {
                    if (!file.DoesOrganisedFileExist)
                    {
                        if (!file.DoesOrganisedDirectoryExist)
                        {
                            Directory.CreateDirectory(file.OrganisedDirectory);
                        }

                        var fileName = options.renameFiles ? file.CorrectFullName : file.CurrentFullName;

                        File.Move(fileName, file.OrganisedFullName);
                    }
                }

                files.Add(file);
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
                fullPath = Path.Combine(_outputDirectory, "Videos - Home", dateTaken.Year.ToString(), dateTaken.ToString("yyyy MM MMMMM"));

            }
            catch (Exception)
            {
                fullPath = Path.Combine(_outputDirectory, "Videos - Home","Missing Date Time");
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
