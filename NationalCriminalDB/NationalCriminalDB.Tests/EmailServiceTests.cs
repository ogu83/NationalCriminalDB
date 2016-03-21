using Microsoft.VisualStudio.TestTools.UnitTesting;
using NationalCriminalDB.EmailService.Models;

namespace NationalCriminalDB.EmailService.Tests
{
    [TestClass]
    public class EmailServiceTests
    {
        [TestMethod]
        public void SendCriminalRecordsTest()
        {
            var request = new EmailSendRequest
            {
                Name = "",
                Age = new DataRange<int>(0, 2000),
                Height = new DataRange<decimal>(0, 3000),
                Weight = new DataRange<decimal>(0, 3000),
                Nationality = "",
                Sex = EmailSendRequest.SexType.All,
                Email = "oguz@artwalkmobile.com"
            };
            var emailservice = new EmailService();
            var response = emailservice.SendCriminalRecords(request);
            Assert.IsTrue(response.Result, "Response Is Not OK");
        }
    }
}