using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DAL;

namespace ABBDal.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CustomerAdd()
        {
            Customer TestCust = new Customer();
            TestCust.CustomerFirstName = "Kim";
            TestCust.CustomerLastName = "Smith";
            TestCust.PhoneNumber = "3304775555";
            CustomerProvider testProvider = new CustomerProvider();
            int myID=testProvider.AddUpdateCustomer(TestCust);
            Assert.IsNotNull(myID);
       }
        [TestMethod]
        public void CustomerUpdate()
        {
            Customer TestCust = new Customer();
            TestCust.CustomerID = 1;
            TestCust.CustomerFirstName = "Neal";
            TestCust.CustomerLastName = "Irwin";
            TestCust.PhoneNumber = "1234325";
            TestCust.Country = "USA";
            TestCust.St = "OH";
            CustomerProvider testProvider = new CustomerProvider();
            int myID = testProvider.AddUpdateCustomer(TestCust);
            Assert.IsNotNull(myID);
        }
    }
}
