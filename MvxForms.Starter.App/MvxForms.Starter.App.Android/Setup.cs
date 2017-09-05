using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Droid.Views;
using MvvmCross.Forms.Droid;
using MvvmCross.Forms.Droid.Presenters;
using MvvmCross.Platform;

namespace MvxForms.Starter.App.Droid
{
    /// <summary>
    /// Setup class
    /// </summary>
    public class Setup : MvxFormsAndroidSetup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="applicationContext"></param>
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        /// <summary>
        /// Create the app
        /// </summary>
        /// <returns></returns>
        protected override IMvxApplication CreateApp()
        {
            return new CoreApp();
        }

        /// <summary>
        /// Create forms app
        /// </summary>
        /// <returns></returns>
        protected override MvvmCross.Forms.Core.MvxFormsApplication CreateFormsApplication()
        {
            return new App();
        }

        /// <summary>
        /// Create and register the default presenter
        /// </summary>
        /// <returns></returns>
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var presenter = new MvxFormsDroidPagePresenter();
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }
    }
}
