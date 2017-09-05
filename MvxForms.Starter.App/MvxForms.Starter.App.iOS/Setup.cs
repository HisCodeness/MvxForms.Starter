using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.iOS;
using MvvmCross.Forms.iOS.Presenters;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;
using UIKit;
using Xamarin.Forms;

namespace MvxForms.Starter.App.iOS
{
    public class Setup : MvxFormsIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        protected override IMvxApplication CreateApp()
        {
            return new CoreApp();
        }
        protected override MvvmCross.Forms.Core.MvxFormsApplication CreateFormsApplication()
        {
            return new App();
        }

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            Forms.Init();

            var xamarinFormsApp = new MvxFormsApplication();

            return new MvxFormsIosPagePresenter(Window, xamarinFormsApp);
        }
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
