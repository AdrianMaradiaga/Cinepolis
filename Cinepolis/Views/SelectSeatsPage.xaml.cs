namespace Cinepolis.Views;

public partial class SelectSeatsPage : ContentPage
{
    private List<string> asientosSeleccionados = new List<string>();
    string RutaImagenP;


    public SelectSeatsPage()
    {
        InitializeComponent();
    }

    public void UpdateMovieInfo(string titulo, string horario, string rutaImagenP, string cine, string sala)
    {
        MovieTituloLabel.Text = titulo;
        MovieHorarioLabel.Text = horario;
        RutaImagenP = rutaImagenP;
        MovieImage.Source = RutaImagenP;
        CineLabel.Text = cine;
        SalaLabel.Text = sala;
    }



    private void OnSeatClicked(object sender, EventArgs e)
    {
        Button seatButton = (Button)sender;
        string asiento = seatButton.Text;

        if (asientosSeleccionados.Contains(asiento))
        {
            // Asiento ya seleccionado, lo quitamos de la lista
            asientosSeleccionados.Remove(asiento);
            seatButton.BackgroundColor = Color.FromHex("#353551");
        }
        else
        {
            // Asiento no seleccionado, lo agregamos a la lista
            asientosSeleccionados.Add(asiento);
            seatButton.BackgroundColor = Color.FromHex("#FFD200"); 
        }
    }

    private async void SiguienteClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SelectSnacks());
    }
}