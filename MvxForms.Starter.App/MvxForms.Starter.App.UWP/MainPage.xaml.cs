using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Uwp.Presenters;
using MvvmCross.Platform;

namespace MvxForms.Starter.App.UWP
{
    /// <summary>
    /// Main page class
    /// </summary>
    public sealed partial class MainPage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsUwpViewPresenter;

            LoadApplication(presenter.FormsApplication);
        }
    }
}
