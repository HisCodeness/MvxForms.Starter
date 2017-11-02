using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvxForms.Starter.Services;

namespace MvxForms.Starter.UnitTests.Services
{
    [TestClass]
    public class AppServiceTest
    {
        [TestMethod]
        public void WhatTimeIsItTest()
        {
            var appService = new AppService();
            var time = appService.WhatTimeIsIt();

            var expectedTime = DateTime.Now.ToString("H:mm:ss");

            Assert.AreEqual(expectedTime, time);
        }
    }
}
