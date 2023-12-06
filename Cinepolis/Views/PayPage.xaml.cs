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
            await DisplayAlert("Error", "Ingrese un número de tarjeta válido (16 dígitos)", "OK");
            return;
        }

        if (fechaVencimientoPicker.Date < DateTime.Now)
        {
            await DisplayAlert("Error", "Seleccione una fecha de vencimiento válida", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(cvvEntry.Text) || cvvEntry.Text.Length != 3)
        {
            await DisplayAlert("Error", "Ingrese un código CVV válido (3 dígitos)", "OK");
            return;
        }

        if (tipoTarjetaPicker.SelectedItem == null)
        {
            await DisplayAlert("Error", "Seleccione un tipo de tarjeta", "OK");
            return;
        }
        await DisplayAlert("Pago", "¡Pago realizado con éxito!", "OK");
        await Navigation.PushAsync(new NavigationPage(new GenerateQRPage()));  
    }
}