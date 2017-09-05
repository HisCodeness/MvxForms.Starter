using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Uwp;
using MvvmCross.Forms.Uwp.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using MvvmCross.Uwp.Platform;
using MvvmCross.Uwp.Views;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;

namespace MvxForms.Starter.App.UWP
{
    public class Setup : MvxFormsWindowsSetup
    {
        private readonly LaunchActivatedEventArgs _launchActivatedEventArgs;

        public Setup(Windows.UI.Xaml.Controls.Frame rootFrame, LaunchActivatedEventArgs e) : base(rootFrame, e)
        {
            _launchActivatedEventArgs = e;
        }


        protected override IMvxApplication CreateApp()
        {
            return new CoreApp();
        }


        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            Forms.Init(_launchActivatedEventArgs);


            var xamarinFormsApp = new MvxFormsApplication();
            var presenter = new MvxFormsUwpPagePresenter(rootFrame, xamarinFormsApp);
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }
    }
}