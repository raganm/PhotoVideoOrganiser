using System.IO;

namespace Models
{
    public class FileAnalysis
    {
        private readonly IGetNewNames _helper;

        private readonly FileInfo _currentFileInfo;
        private readonly FileInfo _correctlyNamedFileInfo;
        private readonly FileInfo _organisedFileInfo;

        public FileAnalysis(string filePath, string outputDirectory, IGetNewNames helper)
        {
            _currentFileInfo = new FileInfo(filePath);

            _helper = helper;
            var organisedFileName = _helper.GetOrganisedFileName(filePath, outputDirectory);

            _organisedFileInfo = new FileInfo(organisedFileName);
            _correctlyNamedFileInfo = new FileInfo( Path.Combine(_currentFileInfo.DirectoryName, _organisedFileInfo.Name));

        }

        public string CurrentFileName
        {
            get
            {
                return _currentFileInfo.Name;
            }
        }
        public bool DoesCurrentFileExist
        {
            get
            {
                return _currentFileInfo.Exists;
            }
        }
        public string CurrentFullName
        {
            get
            {
                return _currentFileInfo.FullName;
            }
        }



        public string CorrectFileName
        {
            get
            {
                return _correctlyNamedFileInfo.Name;
            }
        }
        public string CorrectFullName
        {
            get
            {
                return _correctlyNamedFileInfo.FullName;
            }
        }
        public bool DoesCorrectlyNamedFileExist
        {
            get
            {
                return _correctlyNamedFileInfo.Exists;
            }
        }



        public string OrganisedFullName
        {
            get
            {
                return _organisedFileInfo.FullName;
            }
        }
        public bool DoesOrganisedFileExist
        {
            get
            {
                return _organisedFileInfo.Exists;
            }
        }
        public string OrganisedDirectory
        {
            get
            {
                return _organisedFileInfo.Directory.FullName;

            }
        }
        public bool DoesOrganisedDirectoryExist
        {
            get
            {
                return _organisedFileInfo.Directory.Exists;
                
            }
        }
    }
}
