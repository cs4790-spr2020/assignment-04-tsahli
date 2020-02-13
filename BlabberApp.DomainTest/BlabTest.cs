using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]

    public class BlabTest
    {
        [TestMethod]
        public void TestSetGetMessage()
        {
            // Arrange
            Blab harness = new Blab();
            string expected = "Hello this is the expected message to recieve from the test";
            harness.Message ="Hello this is the expected message to recieve from the test";
            // Act
            string actual = harness.Message;
            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetUserID()
        {
            // Arrange
            Blab harness = new Blab();
            string expected = "fe920bbb-f299-489e-aa1e-dd86c6da51bd";
            harness.UserID = "fe920bbb-f299-489e-aa1e-dd86c6da51bd";
            // Act
            string actual = harness.UserID;
            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetSysId()
        {
            Blab harness = new Blab();
            Assert.IsInstanceOfType(harness.getSysId(), typeof(string));
        }
    }
}
