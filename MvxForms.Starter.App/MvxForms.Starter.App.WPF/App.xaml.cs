using MvvmCross.Core;
using MvvmCross.Forms.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace MvxForms.Starter.App.WPF
{
    /// <summary>
    /// Main application class
    /// </summary>
    public partial class App : MvxApplication
    {
        /// <summary>
        /// Register setup
        /// </summary>
        protected override void RegisterSetup()
        {
            this.RegisterSetupType<MvxFormsWpfSetup<ViewModels.App, FormsApp>>();
        }
    }
}
