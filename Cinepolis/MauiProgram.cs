using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.Extensions.Logging;

namespace Cinepolis
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Gilroy-Bold.ttf", "GilroyBold");
                    fonts.AddFont("Gilroy-Medium.ttf", "GilroyMedium");
                    fonts.AddFont("Gilroy-Regular.ttf", "GilroyRegular");
                    fonts.AddFont("Gilroy-SemiBold.ttf", "GilroySemiBold");
                    fonts.AddFont("Gilroy-Thin.ttf", "GilroyThin");
                });
            builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyBBREgSPMhj3jC0o-3mpDP0xUPbMmyvkVg",
                AuthDomain = "authtest-aa513.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                  new EmailProvider()
                }
            }));


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}