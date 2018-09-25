using MvvmCross.Forms.Views;
using MvxForms.Starter.ViewModels;
using Xamarin.Forms.Xaml;

namespace MvxForms.Starter.App.Views
{
    /// <summary>
    /// Second page
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : MvxContentPage<SecondViewModel>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SecondPage()
        {
            InitializeComponent();
        }
    }
}