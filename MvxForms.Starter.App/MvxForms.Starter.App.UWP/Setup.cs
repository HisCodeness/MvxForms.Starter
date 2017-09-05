﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Uwp;
using MvvmCross.Forms.Uwp.Presenters;
using MvvmCross.Platform;
using MvvmCross.Uwp.Views;
using Windows.ApplicationModel.Activation;
using Xamarin.Forms;

namespace MvxForms.Starter.App.UWP
{
    /// <summary>
    /// Setup class
    /// </summary>
    public class Setup : MvxFormsWindowsSetup
    {
        /// <summary>
        /// Launch event arg
        /// </summary>
        private readonly LaunchActivatedEventArgs launchActivatedEventArgs;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rootFrame"></param>
        /// <param name="e"></param>
        public Setup(Windows.UI.Xaml.Controls.Frame rootFrame, LaunchActivatedEventArgs e) : base(rootFrame, e)
        {
            launchActivatedEventArgs = e;
        }

        /// <summary>
        /// Create app
        /// </summary>
        /// <returns></returns>
        protected override IMvxApplication CreateApp()
        {
            return new CoreApp();
        }

        /// <summary>
        /// Create default presenter
        /// </summary>
        /// <param name="rootFrame"></param>
        /// <returns></returns>
        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            Forms.Init(launchActivatedEventArgs);
            
            var presenter = new MvxFormsUwpPagePresenter(rootFrame, new MvxFormsApplication());
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }
    }
}