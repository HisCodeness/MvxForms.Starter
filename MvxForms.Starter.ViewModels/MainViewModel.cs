using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvxForms.Starter.Services;

namespace MvxForms.Starter.ViewModels
{
    /// <summary>
    /// MainViewModel class
    /// </summary>
    public class MainViewModel : MvxViewModel
    {
        /// <summary>
        /// Test app service
        /// </summary>
        private readonly IAppService appService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="appService"></param>
        public MainViewModel(IAppService appService)
        {
            this.appService = appService;
        }

        /// <summary>
        /// Initialize view model
        /// </summary>
        /// <returns></returns>
        public override Task Initialize()
        {
            //TODO: Add starting logic here

            return base.Initialize();
        }

        #region Bindings tests

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
            RaisePropertyChanged(() => Time);
        }

        private string text = "Hello MvvmCross !";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public string Time
        {
            get { return appService.WhatTimeIsIt(); }
        }

        #endregion
    }
}