using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace MvxForms.Starter.App.Droid
{
    [Activity(
        Label = "MvxForms.Starter"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        /// <summary>
        /// Set the first activity to show
        /// </summary>
        protected override void TriggerFirstNavigate()
        {
            StartActivity(typeof(FormsActivity));
            base.TriggerFirstNavigate();
        }
    }
}
