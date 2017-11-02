using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Droid.Platform;
using MvvmCross.Forms.Platform;
using MvvmCross.Platform.Logging;

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
        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new App();
        }

        /// <summary>
        /// None logger => Known issue in Mvvmcross 5.4
        /// </summary>
        /// <returns></returns>
        protected override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.None;
    }
}
