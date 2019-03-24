using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace MvxForms.Starter.ViewModels.Base
{
    /// <summary>
    /// Base view model for navigation with parameter and result
    /// </summary>
    /// <typeparam name="TParam"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public abstract class BaseViewModel<TParam, TResult> : BaseViewModel<TParam>, IMvxViewModel<TParam, TResult>
    {
        /// <summary>
        /// Close task completion source
        /// </summary>
        public TaskCompletionSource<object> CloseCompletionSource { get; set; }

        /// <summary>
        /// On view destroy, manage close task cancellation
        /// </summary>
        /// <param name="viewFinishing"></param>
        public override void ViewDestroy(bool viewFinishing = true)
        {
            if (viewFinishing && CloseCompletionSource != null && !CloseCompletionSource.Task.IsCompleted && !CloseCompletionSource.Task.IsFaulted)
                CloseCompletionSource?.TrySetCanceled();

            base.ViewDestroy(viewFinishing);
        }
    }
}
