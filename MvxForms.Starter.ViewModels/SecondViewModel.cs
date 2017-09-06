using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvxForms.Starter.ViewModels
{
    /// <summary>
    /// SecondiewModel class
    /// </summary>
    public class SecondViewModel : MvxViewModel<string>
    {
        /// <summary>
        /// Main page text
        /// </summary>
        private string text;

        /// <summary>
        /// Initialize view model
        /// </summary>
        /// <returns></returns>
        public override Task Initialize(string parameter)
        {
            text = parameter;
            return base.Initialize();
        }

        #region Bindings tests

        public IMvxCommand GoBackCommand => new MvxCommand(GoBack);

        private void GoBack()
        {
            Close(this);
        }

        public string Title
        {
            get { return string.Concat("Second page, ", text); }
        }

        #endregion
    }
}