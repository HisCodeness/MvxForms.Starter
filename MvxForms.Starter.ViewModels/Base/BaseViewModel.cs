using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxForms.Starter.ViewModels.Base
{
    /// <summary>
    /// Base view model class
    /// </summary>
    public abstract class BaseViewModel : MvxViewModel
    {
        /// <summary>
        /// Navigation Service
        /// </summary>
        protected readonly IMvxNavigationService NavigationService;

        /// <summary>
        /// Constructor
        /// <para>Instanciate the navigation service</para>
        /// </summary>
        public BaseViewModel()
        {
            NavigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        }
    }
}
