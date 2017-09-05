using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmCross.Forms.Presenters;
using MvvmCross.Platform;
using MvvmCross.Droid.Views;
using Xamarin.Forms;
using MvvmCross.Forms.Core;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Droid.Presenters;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Core;
using MvvmCross.Platform.IoC;

namespace MvxForms.Starter.App.Droid
{
    [Activity(Label = "MvxForms.Starter.App", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //Init forms
            Forms.Init(this, bundle);

            InitialiseMvx();

            //Create mvxformsApp
            var mvxFormsApp = new MvxFormsApplication();
            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsDroidPagePresenter;

            //Assign the viewPresenter
            presenter.FormsApplication = mvxFormsApp;
            LoadApplication(mvxFormsApp);

            IMvxAndroidActivityLifetimeListener list = Mvx.Resolve<IMvxAndroidActivityLifetimeListener>();
            list.OnStart(this);

            //Start mvxApp
            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();
        }

        private void InitialiseMvx()
        {
            if (MvxSingleton<IMvxIoCProvider>.Instance == null)
                Mvx.RegisterSingleton(MvxSimpleIoCContainer.Initialize());

            MvxAndroidSetupSingleton.EnsureSingletonAvailable(this.ApplicationContext)
                                    .EnsureInitialized();
        }
    }
}

