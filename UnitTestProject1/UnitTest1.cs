using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyDataTest()
        {
            Customer mycust = new Customer();
            mycust.CustomerFirstName = "Neal";
            mycust.CustomerLastName = "Irwin";
            
        }
    }
}
