using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvxForms.Starter.ViewModels
{
    /// <summary>
    /// SecondiewModel class
    /// </summary>
    public class SecondViewModel : MvxViewModel<string, string>
    {
        /// <summary>
        /// Navigation service
        /// </summary>
        private readonly IMvxNavigationService navigationService;

        /// <summary>
        /// Main page text
        /// </summary>
        private string text;

        /// <summary>
        /// Constructor
        /// </summary>
        public SecondViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Initialize view model
        /// </summary>
        /// <returns></returns>
        public override void Prepare(string parameter)
        {
            text = parameter;
        }

        #region Bindings tests

        public IMvxCommand GoBackCommand => new MvxCommand(GoBack);

        private void GoBack()
        {
            navigationService.Close(this, "BackParam");
        }

        public string Title
        {
            get { return string.Concat("Second page, ", text); }
        }

        #endregion
    }
}