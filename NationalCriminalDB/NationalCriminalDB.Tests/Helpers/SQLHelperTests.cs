using Microsoft.VisualStudio.TestTools.UnitTesting;
using NationalCriminalDB.EmailService.Models;
using System;

namespace NationalCriminalDB.EmailService.Helpers.Tests
{
    [TestClass]
    public class SQLHelperTests
    {
        [TestMethod]
        public void GetFilteredResultCountTest()
        {
            try
            {
                var criminals = SQLHelper.GetFilteredResult(
                    "",
                    new DataRange<int>(0, 2000),
                    new DataRange<decimal>(0, 3000),
                    new DataRange<decimal>(0, 3000),
                    "",
                    EmailSendRequest.SexType.All);

                if (criminals == null)
                    Assert.Fail("Null Criminal Table");

                Assert.IsTrue(criminals.Count > 0, "No Criminal In DB");
                Assert.IsTrue(criminals.Count == 21, "All Criminals not returned");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                Assert.Fail(ex.StackTrace);
            }
        }

        [TestMethod]
        public void GetFilteredResultAgeTest()
        {
            try
            {
                var criminals = SQLHelper.GetFilteredResult(
                    "",
                    new DataRange<int>(0, 26),
                    new DataRange<decimal>(0, 3000),
                    new DataRange<decimal>(0, 3000),
                    "",
                    EmailSendRequest.SexType.All);

                if (criminals == null)
                    Assert.Fail("Null Criminal Table");

                Assert.IsTrue(criminals.Count > 0, "No Criminal In DB");
                Assert.IsTrue(criminals.Count == 11, "All Criminals not returned");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                Assert.Fail(ex.StackTrace);
            }
        }

        [TestMethod]
        public void GetFilteredResultHeightTest()
        {
            try
            {
                var criminals = SQLHelper.GetFilteredResult(
                    "",
                    new DataRange<int>(0, 200),
                    new DataRange<decimal>(180, 190),
                    new DataRange<decimal>(0, 3000),
                    "",
                    EmailSendRequest.SexType.All);

                if (criminals == null)
                    Assert.Fail("Null Criminal Table");

                Assert.IsTrue(criminals.Count > 0, "No Criminal In DB");
                Assert.IsTrue(criminals.Count == 8, "All Criminals not returned");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                Assert.Fail(ex.StackTrace);
            }
        }

        [TestMethod]
        public void GetFilteredResultWeightTest()
        {
            try
            {
                var criminals = SQLHelper.GetFilteredResult(
                    "",
                    new DataRange<int>(0, 200),
                    new DataRange<decimal>(0, 2000),
                    new DataRange<decimal>(100, 140),
                    "",
                    EmailSendRequest.SexType.All);

                if (criminals == null)
                    Assert.Fail("Null Criminal Table");

                Assert.IsTrue(criminals.Count > 0, "No Criminal In DB");
                Assert.IsTrue(criminals.Count == 6, "All Criminals not returned");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                Assert.Fail(ex.StackTrace);
            }
        }

        [TestMethod]
        public void GetFilteredResultStringTest()
        {
            try
            {
                var criminals = SQLHelper.GetFilteredResult(
                    "Miguela",
                    new DataRange<int>(0, 200),
                    new DataRange<decimal>(0, 2000),
                    new DataRange<decimal>(0, 3000),
                    "Columbia",
                    EmailSendRequest.SexType.All);

                if (criminals == null)
                    Assert.Fail("Null Criminal Table");

                Assert.IsTrue(criminals.Count > 0, "No Criminal In DB");
                Assert.IsTrue(criminals.Count == 1, "All Criminals not returned");
                Assert.IsTrue(criminals[0].BirthDate.Year == 1980, "Birthday Check Failed, it is not Miguela");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                Assert.Fail(ex.StackTrace);
            }
        }

        [TestMethod]
        public void GetFilteredResultSexTest()
        {
            try
            {
                var criminals = SQLHelper.GetFilteredResult(
                    "Mi",
                    new DataRange<int>(0, 200),
                    new DataRange<decimal>(0, 2000),
                    new DataRange<decimal>(0, 3000),
                    "Columbia US",
                    EmailSendRequest.SexType.Female);

                if (criminals == null)
                    Assert.Fail("Null Criminal Table");

                Assert.IsTrue(criminals.Count > 0, "No Criminal In DB");
                Assert.IsTrue(criminals.Count == 1, "All Criminals not returned");
                Assert.IsTrue(criminals[0].BirthDate.Year == 1980, "Birthday Check Failed, it is not Miguela");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                Assert.Fail(ex.StackTrace);
            }
        }
    }
}