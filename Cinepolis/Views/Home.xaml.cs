namespace Cinepolis.Views;
using Cinepolis.Models;
using System.Collections.ObjectModel;

public partial class Home : ContentPage
{
    public ObservableCollection<Peliculas> Movie { get; set; }
    public ObservableCollection<Peliculas> Movie2 { get; set; }

    public Home()
	{
		InitializeComponent();
        InitializationMovies();
        BindingContext = this;
    }



    private void InitializationMovies()
    {
        Movie = new ObservableCollection<Peliculas>
            {
                new Peliculas { Nombre = "The Marvels", Descripcion = "1h 45m", RutaImagen = "https://m.media-amazon.com/images/M/MV5BM2U2YWU5NWMtOGI2Ni00MGMwLWFkNjItMjgyZWMxNjllNTMzXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg"},
                new Peliculas { Nombre = "Trolls 3", Descripcion = "1h 31m", RutaImagen = "https://www.dreamworks.com/storage/cms-uploads/trolls-band-together-poster-thumbnail.jpg"},
                new Peliculas { Nombre = "El Justiciero 3", Descripcion = "2h 21m", RutaImagen = "https://uip.com.co/wp-content/uploads/2023/05/El-Justiciero-capitulo-final-pelicula-estreno-poster-1.webp"},
                new Peliculas { Nombre = "Los Juegos del Hambre: balada", Descripcion = "2h 38m", RutaImagen = "https://cdn.hobbyconsolas.com/sites/navi.axelspringer.es/public/media/image/2023/09/poster-juegos-hambre-balada-pajaros-cantores-serpientes-3143194.jpg?tf=3840x"},
                new Peliculas { Nombre = "Five Nights at Freddy's", Descripcion = "1h 49m", RutaImagen = "https://img.aullidos.com/imagenes/caratulas/five-nights-freddys-poster-sp-2.jpg"}
            };
        Movie2 = new ObservableCollection<Peliculas>
            {
                new Peliculas { Nombre = "Viernes Negro", Descripcion = "1h 46m", RutaImagen = "https://uip.com.co/wp-content/uploads/2023/09/Viernes-negro-pelicula-estreno-poster.webp"},
                new Peliculas { Nombre = "Wonka", Descripcion = "1h 56m", RutaImagen = "https://deadline.com/wp-content/uploads/2023/11/WONKA_INSTA_VERT_MAIN_1638x2048_DOM.jpg?w=800"},
                new Peliculas { Nombre = "Wish: el poder de los deseos", Descripcion = "1h 35m", RutaImagen = "https://preview.redd.it/official-poster-for-disneys-wish-v0-lx37p7pymtqb1.jpg?auto=webp&s=abc51673c574fd3a95870999bf979365e00a9650"},
                new Peliculas { Nombre = "Aquaman 2", Descripcion = "1h 55m", RutaImagen = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/7229d393-c3b8-4703-a41e-e876546d2612/dgg02tq-65e09ba6-f27d-4360-9d11-e593d8e13528.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzcyMjlkMzkzLWMzYjgtNDcwMy1hNDFlLWU4NzY1NDZkMjYxMlwvZGdnMDJ0cS02NWUwOWJhNi1mMjdkLTQzNjAtOWQxMS1lNTkzZDhlMTM1MjguanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.DaSdzsJPrHoogbtyWZSgs0XX9m7bsO1M5es-RzOGu8s"},
                new Peliculas { Nombre = "Napoleón", Descripcion = "2h 38m", RutaImagen = "https://hips.hearstapps.com/hmg-prod/images/napoleon-poster-64ad1f6325a8b.jpg?resize=980:*"}
            };
    }
}