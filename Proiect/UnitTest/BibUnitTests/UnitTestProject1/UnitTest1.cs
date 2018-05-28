using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibApi.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BookController bookController = new BookController();
            Assert.IsNotNull(bookController.Test());
        }
    }
}
