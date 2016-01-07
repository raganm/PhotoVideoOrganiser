using NUnit.Framework;

namespace VideoOrganiser.Tests
{
    [TestFixture]
    public class NameGeneratorTests
    {
        [TestCase("aaa.jpg", "2007-12-12 20.5436626.mpg")]
        [TestCase("ggg.jpg", "2009-08-12 14.07.1467.mpg")]
        [TestCase("kkk.jpg", "2015-07-21 15.21.48869.mp4")]
        public void New_name_is_generated_correctly(string actualName, string expectedname)
        {
            //var sut = new NameGenerator();

            //var workingCopyOfFile = Path.Combine(TestContext.CurrentContext.TestDirectory, "TestFiles", actualName);

            //var newName = sut.GenerateNewName(workingCopyOfFile);

            //Assert.That(newName.ToLower(), Is.EqualTo(expectedname));
        }
    }
}
