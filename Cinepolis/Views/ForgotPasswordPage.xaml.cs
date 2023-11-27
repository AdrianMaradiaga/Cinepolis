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
                await DisplayAlert("Restablecimiento de contraseña", "Por favor, ingrese su correo electrónico.", "OK");
                return;
            }

            await _clientAuth.ResetEmailPasswordAsync(email);
            await DisplayAlert("Restablecimiento de contraseña", "Se ha enviado un correo electrónico con un enlace para restablecer su contraseña", "OK");
            await Navigation.PopAsync();
        }
        catch (FirebaseAuthException error)
        {
            // Manejar errores específicos
            if (error.Reason == AuthErrorReason.UserNotFound)
            {
                await DisplayAlert("Restablecimiento de contraseña", "No se encontró ninguna cuenta asociada con este correo electrónico.", "OK");
            }
            else
            {
                await DisplayAlert("Restablecimiento de contraseña", "Ocurrió un problema: " + error.Reason, "OK");
            }
        }
        catch (Exception ex)
        {
            // Manejar otras excepciones
            await DisplayAlert("Restablecimiento de contraseña", "Ocurrió un problema inesperado: " + ex.Message, "OK");
        }
    }
}