namespace Cinepolis.Views;

public partial class PayPage : ContentPage
{

	public PayPage()
	{
		InitializeComponent();
	}

    private void RealizarPago_Clicked(object sender, EventArgs e)
    {
        validaciones();
    }

    private async void validaciones()
    {
        if (string.IsNullOrWhiteSpace(numeroTarjetaEntry.Text) || numeroTarjetaEntry.Text.Length < 12)
        {
            await DisplayAlert("Error", "Ingrese un n�mero de tarjeta v�lido (16 d�gitos)", "OK");
            return;
        }

        if (fechaVencimientoPicker.Date < DateTime.Now)
        {
            await DisplayAlert("Error", "Seleccione una fecha de vencimiento v�lida", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(cvvEntry.Text) || cvvEntry.Text.Length != 3)
        {
            await DisplayAlert("Error", "Ingrese un c�digo CVV v�lido (3 d�gitos)", "OK");
            return;
        }

        if (tipoTarjetaPicker.SelectedItem == null)
        {
            await DisplayAlert("Error", "Seleccione un tipo de tarjeta", "OK");
            return;
        }
        await DisplayAlert("Pago", "�Pago realizado con �xito!", "OK");
        await Navigation.PushAsync(new NavigationPage(new GenerateQRPage()));  
    }
}