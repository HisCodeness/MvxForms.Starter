using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.iOS;
using MvvmCross.Forms.iOS.Presenters;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using UIKit;
using Xamarin.Forms;

namespace MvxForms.Starter.App.iOS
{
    /// <summary>
    /// Setup class
    /// </summary>
    public class Setup : MvxFormsIosSetup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="applicationDelegate"></param>
        /// <param name="window"></param>
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
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
        /// Create Forms app
        /// </summary>
        /// <returns></returns>
        protected override MvvmCross.Forms.Core.MvxFormsApplication CreateFormsApplication()
        {
            return new App();
        }

        /// <summary>
        /// Create default presenter
        /// </summary>
        /// <returns></returns>
        protected override IMvxIosViewPresenter CreatePresenter()
        {
            Forms.Init();

            var xamarinFormsApp = new MvxFormsApplication();

            return new MvxFormsIosPagePresenter(Window, xamarinFormsApp);
        }
    }
}
