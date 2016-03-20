using Microsoft.VisualStudio.TestTools.UnitTesting;
using NationalCriminalDB.Controllers;
using System.Web.Mvc;

namespace NationalCriminalDB.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void Login()
        {
            // Arrange
            var controller = new AccountController();
            // Act
            var result = controller.Login("") as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Register()
        {
            // Arrange
            var controller = new AccountController();
            // Act
            var result = controller.Register() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ForgotPassword()
        {
            // Arrange
            var controller = new AccountController();
            // Act
            var result = controller.ForgotPassword() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ResetPassword()
        {
            // Arrange
            var controller = new AccountController();
            // Act
            var result = controller.ResetPassword("") as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
