using Microsoft.VisualStudio.TestTools.UnitTesting;
using NationalCriminalDB.Controllers;
using System.Web.Mvc;

namespace NationalCriminalDB.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();
            // Act
            var result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}