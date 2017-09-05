using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Droid.Platform;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Droid.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Core;
using MvvmCross.Platform.IoC;
using Xamarin.Forms;

namespace MvxForms.Starter.App.Droid
{
    [Activity(Label = "MvxForms.Starter.App", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        /// <summary>
        /// Activity creation
        /// </summary>
        /// <param name="bundle"></param>
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //Init forms
            Forms.Init(this, bundle);

            // Init Mvvmcross stuff
            InitialiseMvx();

            // Create mvxformsApp
            var mvxFormsApp = new MvxFormsApplication();
            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsDroidPagePresenter;

            // Assign the viewPresenter
            presenter.FormsApplication = mvxFormsApp;
            LoadApplication(mvxFormsApp);

            // Life time manager
            IMvxAndroidActivityLifetimeListener list = Mvx.Resolve<IMvxAndroidActivityLifetimeListener>();
            list.OnStart(this);

            //Start mvxApp
            var appStart = Mvx.Resolve<IMvxAppStart>();
            appStart.Start();
        }

        /// <summary>
        /// Initialize Mvvmcross stuff
        /// </summary>
        private void InitialiseMvx()
        {
            if (MvxSingleton<IMvxIoCProvider>.Instance == null)
                Mvx.RegisterSingleton(MvxSimpleIoCContainer.Initialize());

            MvxAndroidSetupSingleton.EnsureSingletonAvailable(this.ApplicationContext)
                                    .EnsureInitialized();
        }
    }
}

