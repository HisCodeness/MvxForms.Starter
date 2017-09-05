using MvvmCross.Forms.Core;

namespace MvxForms.Starter.App
{
    /// <summary>
    /// Base Xamarin forms class
    /// </summary>
    public partial class App : MvxFormsApplication
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public App()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Application is starting
        /// </summary>
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        /// <summary>
        /// Application is sleeping
        /// </summary>
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        /// <summary>
        /// Application is waking up
        /// </summary>
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
