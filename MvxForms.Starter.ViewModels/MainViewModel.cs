using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvxForms.Starter.Services;

namespace MvxForms.Starter.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IAppService appService;

        public MainViewModel(IAppService appService)
        {
            this.appService = appService;
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            return base.Initialize();
        }

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
            RaisePropertyChanged(() => Time);
        }

        private string text = "Hello MvvmCross";
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public string Time
        {
            get { return appService.WhatTimeIsIt(); }
        }
    }
}