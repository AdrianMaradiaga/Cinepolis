using QRCoder;
namespace Cinepolis.Views;

public partial class GenerateQRPage : ContentPage
{
	public GenerateQRPage()
	{
		InitializeComponent();
	}

    private void OnGenerateClicked(object sender, EventArgs e)
    {
        string pelicula = InputTextPelicula.Text;
        string hora = InputTextHora.Text;
        string asiento = InputTextAsiento.Text;
        string fecha = InputTextFecha.Text;

        string combinedData = $"Nombre de pelicula: {pelicula}, \nHora: {hora}, \nNúmero de asiento: {asiento}, \nFecha: {fecha}";

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(combinedData, QRCodeGenerator.ECCLevel.L);
        PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
        byte[] qrCodeBytes = qRCode.GetGraphic(20);
        QrCodeImage.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
    }

    private void OnClearFieldsClicked(object sender, EventArgs e)
    {
        InputTextPelicula.Text = string.Empty;
        InputTextHora.Text = string.Empty;
        InputTextAsiento.Text = string.Empty;
        InputTextFecha.Text = string.Empty;
        QrCodeImage.Source = null; // Limpiar la imagen del código QR si es necesario
    }
}