using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace NationalCriminalDB.Controllers.Tests
{
    [TestClass]
    public class ManageControllerTests
    {
        [TestMethod]
        public void ChangePassword()
        {
            Assert.Fail();

            // Arrange
            var controller = new ManageController();
            // Act
            var result = controller.ChangePassword() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}