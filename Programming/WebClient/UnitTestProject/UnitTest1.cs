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
            string userName = "Anna";
            string password = "2222".GetHashCode().ToString(); 

            Service1Client client = new ServiceReference1.Service1Client();

            Assert.IsNotNull(client.Login(userName, password));
        }

        [TestMethod]

        public void SubmitTest()
        {
            int childId = 1;
            int assignmentId = 1;
            DateTime date = DateTime.Now;
            string diskName = "Test Assignment";

            ServiceReference1.Service1Client testService = new Service1Client();

            Assert.AreEqual(1, testService.SubmitHomework(childId, assignmentId, date, diskName));
           
        }
    }
}
