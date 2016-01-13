using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace PhotoOrganiser.Tests
{
    [TestFixture]
    public class OrganiserTests
    {
        private readonly string _outputDirectory = @"C:\dev\PhotoAndVideoOrganiser\PhotoOrganiser.Tests\TestFiles\output";
        private Organiser _organiser;

        [SetUp]
        public void SetUp()
        {
            _organiser = new Organiser(_outputDirectory);

        }

        public void BaseOutputDirectoryIsCreated()
        {
            var baseOutputDirectory = @"c:\output";

            Assert.That(!Directory.Exists(baseOutputDirectory));

            var organiser = new Organiser(baseOutputDirectory);
            organiser.CreateDestinationDirectory(baseOutputDirectory);

            Assert.That(Directory.Exists(baseOutputDirectory));

            Directory.Delete(baseOutputDirectory);
        }


        [TestCase("testPicture3.jpg", @"2015\2015 02 February")]
        public void OrganiseFile(string actualName, string expectedDirectory)
        {
            expectedDirectory = Path.Combine(_outputDirectory, expectedDirectory);

            var workingCopyOfFile = Path.Combine(TestContext.CurrentContext.TestDirectory, "TestFiles", actualName);
            
            _organiser.OrganiseFile(workingCopyOfFile);
            Assert.That(Directory.Exists(expectedDirectory));

            var fileEntries = Directory.GetFiles(expectedDirectory, "*.*", SearchOption.TopDirectoryOnly).ToList();
            Assert.That(fileEntries.Count,Is.EqualTo(1));

            clearFolder(_outputDirectory);
            Directory.Delete(_outputDirectory);
        }
        
        //[Test]
        //public void OrganiseFolder()
        //{
        //    var workingCopyOfFiles = Path.Combine(TestContext.CurrentContext.TestDirectory, "TestFiles");

        //    _organiser.OrganiseDirectory(workingCopyOfFiles, false,true,true,"*.jpg");
        //}

        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }

    }
}
