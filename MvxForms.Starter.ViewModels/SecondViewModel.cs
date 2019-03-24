using System.Threading.Tasks;
using MvvmCross.Commands;
using MvxForms.Starter.ViewModels.Base;

namespace MvxForms.Starter.ViewModels
{
    /// <summary>
    /// SecondiewModel class
    /// </summary>
    public class SecondViewModel : BaseViewModel<string, string>
    {
        /// <summary>
        /// Main page text
        /// </summary>
        private string text;

        /// <summary>
        /// Initialize view model
        /// </summary>
        /// <returns></returns>
        public override Task Initialize()
        {
            text = Parameter;
            return base.Initialize();
        }

        #region Bindings tests

        public IMvxCommand GoBackCommand => new MvxCommand(GoBack);

        private void GoBack()
        {
            NavigationService.Close(this, "BackParam");
        }

        public string Title
        {
            get { return string.Concat("Second page, ", text); }
        }

        #endregion
    }
}