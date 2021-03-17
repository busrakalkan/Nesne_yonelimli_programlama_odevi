using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.ServiceReference1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestWcf
    {
        
        private Service1Client client = null;
        [TestInitialize]
        public void Baslat()
        {
            client = new Service1Client();
        }
        [TestCleanup]
        public void Bitir()
        {
            if (client.State == System.ServiceModel.CommunicationState.Opened)
                client.Close();
        }

        [TestMethod]
        public void TestRegister()
        {
            Assert.AreEqual(1,client.register("busrabusra", "987", "busra@gmail.com"));
        }
        public void TestLogin()
        {
            Assert.AreEqual(0, client.login("busrabusra", "987", "",""));
        }
       
    }
}
