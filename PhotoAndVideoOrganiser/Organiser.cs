using System.Collections.Generic;
using System.IO;
using Models;
using File = System.IO.File;

namespace PhotoAndVideoOrganiser
{
    public class Organiser
    {
        private readonly string _outputDirectory;

        public Organiser(string outputDirectory)
        {
            _outputDirectory = outputDirectory;
        }

        public List<FileAnalysis> OrganiseDirectory(string sourceDirectory, Options options, string extension, IGetNewNames helper)
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
                var file = new FileAnalysis(filePath, _outputDirectory, helper);

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
    }
}
