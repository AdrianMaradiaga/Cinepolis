using Cinepolis.Models;

namespace Cinepolis.Views;

public partial class MovieDetailPage : ContentPage
{
    Peliculas peliculas;
    Cines cine;
    public MovieDetailPage(Peliculas p)
    {
        InitializeComponent();
        peliculas = p;
        BindingContext = p;
    }

    private void BtnHoraro1(object sender, EventArgs e)
    {
        App.selecciones.Horario = "3:00 PM";
        App.selecciones.Titulo = peliculas.Titulo;
        App.selecciones.RutaImagenP = peliculas.RutaImagenP;
        SelectSeatsPage selectSeatsPage = new SelectSeatsPage();

        // Actualizar la información de la película en SelectSeatsPage
        selectSeatsPage.UpdateMovieInfo(App.selecciones.Titulo, App.selecciones.Horario, App.selecciones.RutaImagenP, App.selecciones.Cine);

        // Navegar a la página con la nueva instancia
        Navigation.PushAsync(selectSeatsPage);
    }
    private void BtnHoraro2(object sender, EventArgs e)
    {
        App.selecciones.Horario = "5:00 PM";
        App.selecciones.Titulo = peliculas.Titulo;
        App.selecciones.RutaImagenP = peliculas.RutaImagenP;
        SelectSeatsPage selectSeatsPage = new SelectSeatsPage();

        // Actualizar la información de la película en SelectSeatsPage
        selectSeatsPage.UpdateMovieInfo(App.selecciones.Titulo, App.selecciones.Horario, App.selecciones.RutaImagenP, App.selecciones.Cine);

        // Navegar a la página con la nueva instancia
        Navigation.PushAsync(selectSeatsPage);
    }
    private void BtnHoraro3(object sender, EventArgs e)
    {
        App.selecciones.Horario = "7:00 PM";
        App.selecciones.Titulo = peliculas.Titulo;
        App.selecciones.RutaImagenP = peliculas.RutaImagenP;
        SelectSeatsPage selectSeatsPage = new SelectSeatsPage();
        // Actualizar la información de la película en SelectSeatsPage
        selectSeatsPage.UpdateMovieInfo(App.selecciones.Titulo, App.selecciones.Horario, App.selecciones.RutaImagenP, App.selecciones.Cine);

        // Navegar a la página con la nueva instancia
        Navigation.PushAsync(selectSeatsPage);
    }
}