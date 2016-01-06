using System.IO;
using NUnit.Framework;

namespace PhotoOrganiser.Tests
{
    [TestFixture]
    public class NameGeneratorTests
    {
        [TestCase("testPicture.jpg", "2015-12-22 15.57.15 - 3878.jpg")]
        [TestCase("testPicture2.jpg", "2015-01-11 18.29.48 - 351.jpg")]
        [TestCase("testPicture3.jpg", "2015-02-15 20.25.55 - 3619.jpg")]
        public void New_name_is_generated_correctly(string actualName, string expectedname)
        {
            var sut = new NameGenerator();

            var workingCopyOfFile = Path.Combine(TestContext.CurrentContext.TestDirectory, "TestFiles", actualName);

            var newName = sut.GenerateNewName(workingCopyOfFile);

            Assert.That(newName.ToLower(), Is.EqualTo(expectedname));
        }
    }
}
