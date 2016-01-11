using System.Collections.Generic;
using System.IO;
using System.Linq;
using Models;
using NUnit.Framework;

namespace PhotoOrganiser.Tests
{
    [TestFixture]
    public class RenamerTests
    {
        private readonly string _renameTestDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, @"TestFiles\RenameTest");
        private List<string> _filesAvailableForRenaming;

        [SetUp]
        public void SetUp()
        {
            _filesAvailableForRenaming = Directory.GetFiles(_renameTestDirectory, "*.*", SearchOption.TopDirectoryOnly).ToList();

            Assert.That(_filesAvailableForRenaming.Count, Is.EqualTo(2));
            Assert.That(_filesAvailableForRenaming.FirstOrDefault(s => s.Contains("aaa.jpg")),Is.Not.Null);
            Assert.That(_filesAvailableForRenaming.FirstOrDefault(s => s.Contains("bbb.jpg")),Is.Not.Null);
        }

        [TearDown]
        public void TearDown()
        {
            clearFolder(_renameTestDirectory);
            Directory.Delete(_renameTestDirectory);
        }

        [Test]
        public void File_is_successfully_renamed()
        {
            var sut = new Renamer();

            sut.Rename(_filesAvailableForRenaming.FirstOrDefault(s => s.Contains("aaa.jpg")),false);

            var workingCopyOfFilesRenamed = Directory.GetFiles(_renameTestDirectory, "*.*", SearchOption.TopDirectoryOnly).ToList();

            Assert.That(workingCopyOfFilesRenamed.Count, Is.EqualTo(2));
            Assert.That(workingCopyOfFilesRenamed.FirstOrDefault(s => s.Contains("aaa.jpg")), Is.Null);

            Assert.That(workingCopyOfFilesRenamed.FirstOrDefault(s => s.Contains("2015-03-01 14.03.52 - 2660.jpg")), Is.Not.Null);
            Assert.That(workingCopyOfFilesRenamed.FirstOrDefault(s => s.Contains("bbb.jpg")), Is.Not.Null);
        }


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
