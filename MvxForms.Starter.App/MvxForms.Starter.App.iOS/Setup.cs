using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.iOS;
using MvvmCross.Forms.Platform;
using MvvmCross.iOS.Platform;
using UIKit;

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
        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new App();
        }
    }
}
