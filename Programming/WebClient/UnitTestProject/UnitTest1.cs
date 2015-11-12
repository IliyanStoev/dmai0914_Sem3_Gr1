using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.ServiceReference1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string userName = "Anna";
            string password = "2222".GetHashCode().ToString(); 

            Service1Client client = new ServiceReference1.Service1Client();

            Assert.IsNotNull(client.Login(userName, password));
        }
    }
}
