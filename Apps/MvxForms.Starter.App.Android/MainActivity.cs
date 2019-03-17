using Android.App;
using Android.Content.PM;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;

namespace MvxForms.Starter.App.Android
{
    [Activity(
            Label = "MvxForms.Starter"
            , MainLauncher = true
            , Icon = "@mipmap/ic_launcher"
            , Theme = "@style/MainTheme.Splash"
            , ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
            , LaunchMode = LaunchMode.SingleTask
            , NoHistory = true)]
    public class MainActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<ViewModels.App, FormsApp>, ViewModels.App, FormsApp>
    {
    }
}

