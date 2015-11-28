using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.ServiceReference1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoginTest()
        {
            Service1Client client = new ServiceReference1.Service1Client();

            Assert.IsNotNull(client.Login("Anna", "2222".GetHashCode().ToString()));
        }

        [TestMethod]

        public void SubmitHomeworkTest()
        {

            ServiceReference1.Service1Client testService = new Service1Client();

            Assert.AreEqual(1, testService.SubmitHomework(3, 2, DateTime.Now, "Test Assignment"));
           
        }

        [TestMethod]

        public void CreateAssignmentTest()
        {
           
            ServiceReference1.Service1Client testService = new Service1Client();

            Assert.AreEqual(1, testService.CreateAssignment(1, "Math", "TestAssignment", "2+2=?", DateTime.Now, DateTime.Now));

        }

        [TestMethod]
        public void CreateTutoringTime()
        {
            ServiceReference1.Service1Client testService = new Service1Client();

            Assert.AreEqual(1, testService.CreateTutoringTime(DateTime.Now, true, 1, "10:00"));
        }
    }
}
