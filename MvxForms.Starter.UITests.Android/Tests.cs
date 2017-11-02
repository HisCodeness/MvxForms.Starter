using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace MvxForms.Starter.UITests.Android
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
                    .Android
                    .ApkFile(@"..\..\..\MvxForms.Starter.App\MvxForms.Starter.App.Android\bin\Release\com.MvxForms.Starter.App.apk")
                    .EnableLocalScreenshots()
                    .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void AppNavigateSecondView()
        {
            app.WaitForElement(c => c.Marked("BtnNext").Text("Go next"));
            app.Tap(c => c.Marked("BtnNext"));
            app.WaitForElement(c => c.Marked("LblTitle"));
            app.Screenshot("Second screen.");
        }

        [Test]
        public void AppNavigateBack()
        {
            app.WaitForElement(c => c.Marked("BtnNext").Text("Go next"));
            app.Tap(c => c.Marked("BtnNext"));
            app.WaitForElement(c => c.Marked("LblTitle"));
            app.Tap(c => c.Marked("BtnBack"));
            app.WaitForElement(c => c.Marked("BtnNext").Text("Go next"));
            app.WaitForElement(c => c.Marked("EntryText").Text("Hello MvvmCross !BackParam"));
            app.Screenshot("First screen back");
        }

        [Test]
        public void AppResetBtn()
        {
            app.WaitForElement(c => c.Marked("EntryText").Text("Hello MvvmCross !"));
            app.Tap(c => c.Marked("BtnReset"));
            app.WaitForElement(c => c.Marked("EntryText").Text("Hello MvvmCross"));
            app.Screenshot("First screen reset");
        }
    }
}

