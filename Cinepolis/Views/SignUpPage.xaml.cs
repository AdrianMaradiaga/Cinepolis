using Firebase.Auth;

namespace Cinepolis.Views;

public partial class SignUpPage : ContentPage
{
    private readonly FirebaseAuthClient _client;
    private const string FirebaseApiKey = "AIzaSyBBREgSPMhj3jC0o-3mpDP0xUPbMmyvkVg";
    private const string RequestUrl = "https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key=" + FirebaseApiKey;


    public SignUpPage(FirebaseAuthClient firebaseAuthClient)
	{  
		InitializeComponent();
        _client = firebaseAuthClient;
	}

    private async void SignUpButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (PasswordEntry.Text == ConfirmPasswordEntry.Text)
            {
                var user = await _client.CreateUserWithEmailAndPasswordAsync(EmailEntry.Text, PasswordEntry.Text);
                await SendVerificationEmailAsync(user.User.GetIdTokenAsync().Result);

                await DisplayAlert("Éxito", "Cuenta creada", "OK");
                await Navigation.PushAsync(new LoginPage(_client));
            }
            else
            {
                await DisplayAlert("Error", "Las contraseñas ingresadas no son iguales", "OK");
            }
        }
        catch (FirebaseAuthException firebaseAuthException)
        {
            if (firebaseAuthException.Reason == AuthErrorReason.EmailExists)
            {
                await DisplayAlert("Error", "El correo electrónico ya está registrado.", "OK");
            }
            else if(firebaseAuthException.Reason == AuthErrorReason.WeakPassword)
            {
                await DisplayAlert("Error", "Contraseña debil", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Error de autenticación: " + firebaseAuthException.Reason, "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Ocurrió un problema: " + ex.Message, "OK");
            Console.WriteLine(ex.StackTrace);
        }
    }


    private static readonly HttpClient client = new HttpClient();

    public static async Task SendVerificationEmailAsync(string idToken)
    {
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var content = new StringContent("{\"requestType\":\"VERIFY_EMAIL\", \"idToken\":\"" + idToken + "\"}");
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(RequestUrl, content);
            response.EnsureSuccessStatusCode();
    }

    private async void OnSignInLinkClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage(_client));
    }
}