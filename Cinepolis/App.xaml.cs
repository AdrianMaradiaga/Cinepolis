using Firebase.Auth;
using Cinepolis.Views;
using Cinepolis.Models;

namespace Cinepolis
{
    public partial class App : Application
    {
        public App(FirebaseAuthClient firebaseAuthClient)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage(firebaseAuthClient));
            //MainPage = new AppShell();
        }
        public static Selecciones selecciones = new Selecciones();
    }
}