
using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace MvxForms.Starter.App.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<ViewModels.App, FormsApp>, ViewModels.App, FormsApp>
    {
        /// <summary>
        /// Used for UI tests
        /// </summary>
        /// <param name="uiApplication"></param>
        /// <param name="launchOptions"></param>
        /// <returns></returns>
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
#if DEBUG
    Xamarin.Calabash.Start();   
#endif
            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
