using System.Linq;
using System.Reflection;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvxForms.Starter.ViewModels;

namespace MvxForms.Starter.App
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            var serviceAssembly = Assembly.Load(new AssemblyName("MvxForms.Starter.Services"));

            CreatableTypes(serviceAssembly)
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
