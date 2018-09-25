using MvvmCross.Forms.Views;
using MvxForms.Starter.ViewModels;
using Xamarin.Forms.Xaml;

namespace MvxForms.Starter.App.Views
{
    /// <summary>
    /// First page
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : MvxContentPage<FirstViewModel>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FirstPage()
        {
            InitializeComponent();
        }
    }
}