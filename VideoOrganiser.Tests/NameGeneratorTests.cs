using System.IO;
using NUnit.Framework;

namespace VideoOrganiser.Tests
{
    [TestFixture]
    public class NameGeneratorTests
    {
        [TestCase("aaa.mpg", "2007-12-12 20.54.36 - 641944.mpg")]
        [TestCase("ggg.mpg", "2009-08-12 15.07.14 - 68780.mpg")]
        [TestCase("kkk.mp4", "2015-07-21 16.21.48 - 889995.mp4")]
        public void New_name_is_generated_correctly(string actualName, string expectedname)
        {
            var sut = new NameGenerator();

            var workingCopyOfFile = Path.Combine(TestContext.CurrentContext.TestDirectory, "TestFiles", actualName);

            var newName = sut.GenerateNewName(workingCopyOfFile);

            Assert.That(newName.ToLower(), Is.EqualTo(expectedname));
        }
    }
}
