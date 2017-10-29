using MvvmCross.Core.ViewModels;

namespace MvxForms.Starter.ViewModels
{
    /// <summary>
    /// Base view model class
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <typeparam name="R"></typeparam>
    public abstract class BaseViewModel<P, R> : MvxViewModel<P, R>
    {
        /// <summary>
        /// Parameters passed to view model
        /// </summary>
        protected P Parameter;

        /// <summary>
        /// Initialize view model, read parameters
        /// </summary>
        /// <returns></returns>
        public override void Prepare(P parameter)
        {
            Parameter = parameter;
        }
    }
}
