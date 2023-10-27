using System;
using Jenkins.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jenkins.Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDataService dataService = new DataService();
            var hostName = dataService.GetHost();
            Assert.AreEqual(Environment.MachineName, hostName);
        }
    }
}