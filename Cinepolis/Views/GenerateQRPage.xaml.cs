using QRCoder;
using Firebase.Database;
using System.Collections.ObjectModel;
using Cinepolis.Models;
using Firebase.Database.Query;

namespace Cinepolis.Views;

public partial class GenerateQRPage : ContentPage
{
    FirebaseClient client = new FirebaseClient("https://cinepolis-d5adc-default-rtdb.firebaseio.com/");

    public GenerateQRPage()
	{
		InitializeComponent();
        InputTextPelicula.Text = App.selecciones.Titulo;
        InputTextHora.Text = App.selecciones.Horario;
        InputTextUsuario.Text = App.selecciones.Usuario;
        InputTextCine.Text = App.selecciones.Cine;
        InputTextSala.Text = App.selecciones.Sala;

        InputTextSala.IsEnabled = false;
        InputTextUsuario.IsEnabled = false;
        InputTextPelicula.IsEnabled = false;
        InputTextCine.IsEnabled = false;
        InputTextHora.IsEnabled = false;
    }

    private void OnGenerateClicked(object sender, EventArgs e)
    {
        string pelicula = InputTextPelicula.Text;
        string hora = InputTextHora.Text;
        string asiento = InputTextAsiento.Text;
        string usuario = InputTextUsuario.Text;
        string cine = InputTextCine.Text;
        string sala = InputTextSala.Text;

        string combinedData = $"Nombre de pelicula: {pelicula}, \nUsurario: {usuario}, \nHora: {hora}, \nCine: {cine}, \nNúmero de asiento: {asiento}, \nSala: {sala}";

        enviarDatos();
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(combinedData, QRCodeGenerator.ECCLevel.L);
        PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
        byte[] qrCodeBytes = qRCode.GetGraphic(20);
        QrCodeImage.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
    }


    private async void enviarDatos()
    {
        var facturaData = new Dictionary<string, string>
            {
                { "usuario", InputTextUsuario.Text },
                { "pelicula", InputTextPelicula.Text },
                { "cine", InputTextCine.Text },
                { "horario", InputTextHora.Text },
                { "sala", InputTextSala.Text },
                { "asiento", InputTextAsiento.Text }
            };

        await client.Child("Facturas").PostAsync(facturaData);
    }



    private void OnClearFieldsClicked(object sender, EventArgs e)
    {
        // Limpiar campos de texto
        InputTextPelicula.Text = string.Empty;
        InputTextHora.Text = string.Empty;
        InputTextAsiento.Text = string.Empty;
        InputTextUsuario.Text = string.Empty;
        InputTextCine.Text = string.Empty;
        InputTextSala.Text = string.Empty;

        // Limpiar imagen QR
        QrCodeImage.Source = null;

        // Restablecer campos deshabilitados con los valores originales de Selecciones
        InputTextPelicula.Text = App.selecciones.Titulo;
        InputTextHora.Text = App.selecciones.Horario;
        InputTextUsuario.Text = App.selecciones.Usuario;
        InputTextCine.Text = App.selecciones.Cine;
        InputTextSala.Text = App.selecciones.Sala;
    }
}