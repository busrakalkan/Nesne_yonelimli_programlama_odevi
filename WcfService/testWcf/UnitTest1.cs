using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testWcf.ServiceReference1;

namespace testWcf
{
    [TestClass]
    public class UnitTest1
    {
        private Service1Client control = null;

        [TestInitialize]
        public void Baslat()
        {
            control = new Service1Client();
        }

        [TestCleanup]
        public void Bitir()
        {
            if (control.State == System.ServiceModel.CommunicationState.Opened)
            {
                control.Close();
            }
        }
        [TestMethod]
        public void TestRegister()
        {
            
            var result = control.register("busrabusra", "987", "busra@gmail.com");
            Assert.AreEqual(1, result);
           
        }
        public void TestLogin()
        {
            
            var result = control.login("busrabusra", "987", "", "");
            Assert.AreEqual(0, result);
            
        }
    }
}
