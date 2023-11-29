using Firebase.Auth;
using Cinepolis.Views;
namespace Cinepolis
{
    public partial class App : Application
    {
        public App(FirebaseAuthClient firebaseAuthClient)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage(firebaseAuthClient));
            //MainPage = new NavigationPage(new Home());
        }
    }
}