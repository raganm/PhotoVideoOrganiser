using System;
using System.IO;
using NUnit.Framework;

namespace PhotoOrganiser.Tests
{
    [TestFixture]
    public class AnalyserTests
    {
        [Test,Explicit]
        public void Test_run()
        {
            const string path = @"c:\testFiles";

            var analyser = new Analyser();

            analyser.AnalyseDirectory(path);
        }
    }
}
