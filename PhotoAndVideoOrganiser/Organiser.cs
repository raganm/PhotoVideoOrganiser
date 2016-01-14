using System;
using System.Collections.Generic;
using System.IO;
using Models;
using File = System.IO.File;

namespace PhotoAndVideoOrganiser
{
    public class Organiser
    {
        private readonly string _outputDirectory;
        private readonly string _duplicateDirectory;

        public Organiser(string outputDirectory, string duplicateDirectory)
        {
            _outputDirectory = outputDirectory;
            _duplicateDirectory = duplicateDirectory;
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
                    else
                    {
                        FileDuplicateFile(file.CurrentFullName);
                    }
                }

                if (options.organiseFiles)
                {
                    var fileName = options.renameFiles ? file.CorrectFullName : file.CurrentFullName;

                    if (!file.DoesOrganisedFileExist)
                    {
                        if (!file.DoesOrganisedDirectoryExist)
                        {
                            Directory.CreateDirectory(file.OrganisedDirectory);
                        }

                        File.Move(fileName, file.OrganisedFullName);
                    }
                    else
                    {
                        FileDuplicateFile(fileName);
                    }
                }

                files.Add(file);
            }

            return files;
        }

        private void FileDuplicateFile(string path)
        {
            var fi = new FileInfo(path);

            var duplicatePath = Path.Combine(_duplicateDirectory,
                string.Format("{0} - {1}{2}", Path.GetFileNameWithoutExtension(fi.Name), Guid.NewGuid().ToString(), fi.Extension));

            var fi2 = new FileInfo(duplicatePath);

            if (!fi2.Directory.Exists)
            {
                Directory.CreateDirectory(fi2.Directory.FullName);
            }

            File.Move(path, duplicatePath);
        }
    }
}
