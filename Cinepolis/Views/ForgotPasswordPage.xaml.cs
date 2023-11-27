using Firebase.Auth;

namespace Cinepolis.Views;

public partial class ForgotPasswordPage : ContentPage
{
    private readonly FirebaseAuthClient _clientAuth;

    public ForgotPasswordPage(FirebaseAuthClient firebaseAuthClient)
	{
		InitializeComponent();
		_clientAuth = firebaseAuthClient;
	}

	private async void ResetPasswordButton_Clicked(object sender, EventArgs e)
	{
		try
		{
			var email = EmailEntry.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                await DisplayAlert("Restablecimiento de contrase�a", "Por favor, ingrese su correo electr�nico.", "OK");
                return;
            }

            await _clientAuth.ResetEmailPasswordAsync(email);
            await DisplayAlert("Restablecimiento de contrase�a", "Se ha enviado un correo electr�nico con un enlace para restablecer su contrase�a", "OK");
            await Navigation.PopAsync();
        }
        catch (FirebaseAuthException error)
        {
            // Manejar errores espec�ficos
            if (error.Reason == AuthErrorReason.UserNotFound)
            {
                await DisplayAlert("Restablecimiento de contrase�a", "No se encontr� ninguna cuenta asociada con este correo electr�nico.", "OK");
            }
            else
            {
                await DisplayAlert("Restablecimiento de contrase�a", "Ocurri� un problema: " + error.Reason, "OK");
            }
        }
        catch (Exception ex)
        {
            // Manejar otras excepciones
            await DisplayAlert("Restablecimiento de contrase�a", "Ocurri� un problema inesperado: " + ex.Message, "OK");
        }
    }
}