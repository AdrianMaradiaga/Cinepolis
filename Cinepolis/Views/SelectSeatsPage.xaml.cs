namespace Cinepolis.Views;

public partial class SelectSeatsPage : ContentPage
{
    private List<string> asientosSeleccionados = new List<string>();
    string RutaImagenP;


    public SelectSeatsPage()
    {
        InitializeComponent();
    }

    public void UpdateMovieInfo(string titulo, string horario, string rutaImagenP, string cine)
    {
        MovieTituloLabel.Text = titulo;
        MovieHorarioLabel.Text = horario;
        RutaImagenP = rutaImagenP;
        MovieImage.Source = RutaImagenP;
        CineLabel.Text = cine;
    }

    private void OnSeatClicked(object sender, EventArgs e)
    {
        // Obtener el botón que activó el evento
        var button = (Button)sender;
        string seatNumber = button.Text;

        // Color rojo significa que esta ocupado (#CF010B)
        if (button.BackgroundColor == Color.FromHex("#CF010B"))
        {
            DisplayAlert("Asiento ocupado", "Seleccione otro asiento, este ya ha sido ocupado.", "Aceptar");
            return;
        }

        // Cambiar el color del botón a amarillo (#FFD200) si está azul (#353551)
        if (button.BackgroundColor == Color.FromHex("#353551"))
        {
            if (!asientosSeleccionados.Contains(seatNumber))
            {
                // Si el asiento no está en el arreglo, lo agregamos
                asientosSeleccionados.Add(seatNumber);
            }
            button.BackgroundColor = Color.FromHex("#FFD200");
        }
        else // Restaurar el color original si está naranja
        {
            button.BackgroundColor = Color.FromHex("#353551");
            // Si el botón está en color naranja (#FFA500)
            if (asientosSeleccionados.Contains(seatNumber))
            {
                // Si el asiento está en el arreglo, lo eliminamos (se deselecciona)
                asientosSeleccionados.Remove(seatNumber);
            }
        }
    }

    private async void SiguienteClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SelectSnacks());
    }
}