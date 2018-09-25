using System.Reflection;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MvxForms.Starter.ViewModels
{
    /// <summary>
    /// App class
    /// </summary>
    public class App : MvxApplication
    {
        /// <summary>
        /// Initialize App
        /// </summary>
        public override void Initialize()
        {
            var serviceAssembly = Assembly.Load(new AssemblyName("MvxForms.Starter.Services"));

            CreatableTypes(serviceAssembly)
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
