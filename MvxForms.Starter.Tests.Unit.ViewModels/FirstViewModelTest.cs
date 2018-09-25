using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmCross.Navigation;
using MvvmCross.Tests;
using MvxForms.Starter.Services;
using MvxForms.Starter.ViewModels;

namespace MvxForms.Starter.Tests.Unit.ViewModels
{
    [TestClass]
    public class FirstViewModelTest : MvxIoCSupportingTest
    {
        protected override void AdditionalSetup()
        {
            var navService = new Mock<IMvxNavigationService>();
            navService.Setup(o => o.Navigate<SecondViewModel, string, string>("Hello MvvmCross !", null, default(CancellationToken))).ReturnsAsync("back parameter");
            Ioc.RegisterSingleton(navService.Object);

            var appService = new Mock<IAppService>();
            appService.Setup(o => o.WhatTimeIsIt()).Returns(DateTime.Now.ToString("H:mm:ss"));
            Ioc.RegisterSingleton(appService.Object);
        }

        [TestMethod]
        public void PropertiesTest()
        {
            Setup();

            var mainViewModel = new FirstViewModel(Ioc.Resolve<IAppService>(), Ioc.Resolve<IMvxNavigationService>());
            Assert.AreEqual(DateTime.Now.ToString("H:mm:ss"), mainViewModel.Time);
            Assert.AreEqual("Hello MvvmCross !", mainViewModel.Text);
        }

        [TestMethod]
        public void ResetCommandTest()
        {
            Setup();

            var mainViewModel = new FirstViewModel(Ioc.Resolve<IAppService>(), Ioc.Resolve<IMvxNavigationService>());
            mainViewModel.ResetTextCommand.Execute();
            Assert.AreEqual("Hello MvvmCross", mainViewModel.Text);
        }

        [TestMethod]
        public void NextCommandTest()
        {
            Setup();

            var mainViewModel = new FirstViewModel(Ioc.Resolve<IAppService>(), Ioc.Resolve<IMvxNavigationService>());
            mainViewModel.NextCommand.Execute();
            Assert.AreEqual("Hello MvvmCross !back parameter", mainViewModel.Text);
        }
    }
}

