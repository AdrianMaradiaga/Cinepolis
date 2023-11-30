using Firebase.Auth;
using Firebase.Auth.Repository;
using System.Diagnostics;

namespace Cinepolis.Views;

public partial class LoginPage : ContentPage
{

    private readonly FirebaseAuthClient _clientAuth;
    private FileUserRepository _userRepository;
    private UserInfo _userInfo;
    private FirebaseCredential _credential;

	public LoginPage(FirebaseAuthClient firebaseAuthClient)
	{
		InitializeComponent();
        _clientAuth = firebaseAuthClient;
        _userRepository = new FileUserRepository("Cinepolis");

        IsStoredUser();
    }

    private async void IsStoredUser()
    {
        if(_userRepository.UserExists()) {
            (_userInfo, _credential) = _userRepository.ReadUser();
            await Navigation.PushAsync(new NavigationPage(new SnacksPage())); 
        }
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            var userCredential = await _clientAuth.SignInWithEmailAndPasswordAsync(EmailEntry.Text, PasswordEntry.Text);

            if (RememberPassowrd.IsChecked)
            {
                _userRepository.SaveUser(userCredential.User);
            }
            else
            {
                _userRepository.DeleteUser();
            }

            await Navigation.PushAsync(new NavigationPage(new SnacksPage())); 
        }
        catch (FirebaseAuthException firebaseAuthException)
        {
            if (firebaseAuthException.Reason == AuthErrorReason.UserNotFound)
            {
                await DisplayAlert("Inicio de sesión", "El correo electrónico no está registrado.", "OK");
            }
            else if (firebaseAuthException.Reason == AuthErrorReason.WrongPassword)
            {
                await DisplayAlert("Inicio de sesión", "Contraseña incorrecta.", "OK");
            }
            else
            {
                await DisplayAlert("Inicio de sesión", "Ocurrió un problema: " + firebaseAuthException.Reason, "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Inicio de sesión", "Ocurrió un problema: " + ex.Message, "OK");
            Console.WriteLine(ex.StackTrace);
        }
    }


    private void ForgotPasswordLinkClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ForgotPasswordPage(_clientAuth));
    }

    private async void OnSignUpLinkClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpPage(_clientAuth));
    }
}