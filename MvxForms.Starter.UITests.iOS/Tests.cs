using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace iOSUITest
{
    [TestFixture]
    public class Tests
    {
        iOSApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
                .iOS
                .AppBundle(@"..\..\..\MvxForms.Starter.App.iOS\bin\iPhoneSimulator\Debug\MvxForms.Starter.App.iOS.app")
                .EnableLocalScreenshots()
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }
    }
}

