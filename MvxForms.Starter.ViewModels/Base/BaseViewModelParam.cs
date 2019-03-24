using MvvmCross.ViewModels;

namespace MvxForms.Starter.ViewModels.Base
{
    /// <summary>
    /// Base view model for navigation with parameter
    /// </summary>
    /// <typeparam name="TParam"></typeparam>
    public abstract class BaseViewModel<TParam> : BaseViewModel, IMvxViewModel<TParam>
    {
        /// <summary>
        /// Parameters passed to view model
        /// </summary>
        protected TParam Parameter;

        /// <summary>
        /// Initialize view model, read parameters
        /// </summary>
        public void Prepare(TParam parameter)
        {
            Parameter = parameter;
        }
    }
}
