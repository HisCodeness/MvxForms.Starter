using Xamarin.UITest;

namespace MvxForms.Starter.Tests.UI.Android
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(@"..\..\..\MvxForms.Starter.App\MvxForms.Starter.App.Android\bin\Release\MvxForms.Starter.App.Android-Signed.apk")
                    .EnableLocalScreenshots()
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}