using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hello.Data.Tests
{
    [TestClass]
    public class FileDataSourceTest
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void GivenAnInvalidPath_WhenCallingRead_ThenThrowException()
        {
            FileDataSource fds = new FileDataSource("hello2.txt");
            fds.Read();

        }

        [TestMethod]
        public void GivenAValidPath_WhenCallingRead_ThenReturnsFileContents()
        {
            FileDataSource fds = new FileDataSource("hello.txt");
            var myContent = fds.Read();

            Assert.AreEqual("Hi!", myContent);

        }
    }
}
