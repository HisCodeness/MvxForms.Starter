using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;

namespace MvxForms.Starter.App.UWP
{
    /// <summary>
    /// Main application class
    /// </summary>
    sealed partial class App
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public App()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// Uwp application
    /// </summary>
    public abstract class UwpApplication : MvxWindowsApplication<MvxFormsWindowsSetup<ViewModels.App, FormsApp>, ViewModels.App, FormsApp, MainPage>
    {
    }
}
