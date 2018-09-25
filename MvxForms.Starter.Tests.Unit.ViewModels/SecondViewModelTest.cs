using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmCross.Navigation;
using MvvmCross.Tests;
using MvxForms.Starter.ViewModels;

namespace MvxForms.Starter.Tests.Unit.ViewModels
{
    [TestClass]
    public class SecondViewModelTest : MvxIoCSupportingTest
    {
        protected override void AdditionalSetup()
        {
            Ioc.RegisterSingleton(new Mock<IMvxNavigationService>().Object);
        }

        [TestMethod]
        public void TitleTest()
        {
            Setup();

            var secondViewModel = new SecondViewModel(Ioc.Resolve<IMvxNavigationService>());
            Assert.AreEqual("Second page, ", secondViewModel.Title);
        }

        [TestMethod]
        public void ParameterTest()
        {
            Setup();

            var secondViewModel = new SecondViewModel(Ioc.Resolve<IMvxNavigationService>());
            secondViewModel.Prepare("test");
            secondViewModel.Initialize();

            Assert.AreEqual("Second page, test", secondViewModel.Title);
        }
    }
}
