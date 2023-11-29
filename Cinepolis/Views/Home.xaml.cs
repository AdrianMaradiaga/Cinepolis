namespace Cinepolis.Views;
using Cinepolis.Models;
using System.Collections.ObjectModel;

public partial class Home : ContentPage
{
    public ObservableCollection<Movies> Movie { get; set; }
    public ObservableCollection<Movies> Movie2 { get; set; }

    public Home()
	{
		InitializeComponent();
        InitializationMovies();
        BindingContext = this;
    }

    private void InitializationMovies()
    {
        Movie = new ObservableCollection<Movies>
        {
                new Movies { Name = "The Marvels", MovieTime = new TimeSpan(1, 45, 0), Image = "https://m.media-amazon.com/images/M/MV5BM2U2YWU5NWMtOGI2Ni00MGMwLWFkNjItMjgyZWMxNjllNTMzXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg"},
                new Movies { Name = "Trolls 3", MovieTime = new TimeSpan(1, 31, 0), Image = "https://www.dreamworks.com/storage/cms-uploads/trolls-band-together-poster-thumbnail.jpg"},
                new Movies { Name = "El Justiciero 3", MovieTime = new TimeSpan(2, 21, 0), Image = "https://uip.com.co/wp-content/uploads/2023/05/El-Justiciero-capitulo-final-pelicula-estreno-poster-1.webp"},
                new Movies { Name = "Los Juegos del Hambre: balada", MovieTime = new TimeSpan(2, 38, 0), Image = "https://cdn.hobbyconsolas.com/sites/navi.axelspringer.es/public/media/image/2023/09/poster-juegos-hambre-balada-pajaros-cantores-serpientes-3143194.jpg?tf=3840x"},
                new Movies { Name = "Five Nights at Freddy's", MovieTime = new TimeSpan(1, 49, 0), Image = "https://img.aullidos.com/imagenes/caratulas/five-nights-freddys-poster-sp-2.jpg"}
        };
        Movie2 = new ObservableCollection<Movies>
        {
                new Movies { Name = "Viernes Negro", MovieTime = new TimeSpan(1, 46, 0), Image = "https://uip.com.co/wp-content/uploads/2023/09/Viernes-negro-pelicula-estreno-poster.webp"},
                new Movies { Name = "Wonka", MovieTime = new TimeSpan(1, 56, 0), Image = "https://deadline.com/wp-content/uploads/2023/11/WONKA_INSTA_VERT_MAIN_1638x2048_DOM.jpg?w=800"},
                new Movies { Name = "Wish: el poder de los deseos", MovieTime = new TimeSpan(1, 35, 0), Image = "https://preview.redd.it/official-poster-for-disneys-wish-v0-lx37p7pymtqb1.jpg?auto=webp&s=abc51673c574fd3a95870999bf979365e00a9650"},
                new Movies { Name = "Aquaman 2", MovieTime = new TimeSpan(1, 55, 0), Image = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/7229d393-c3b8-4703-a41e-e876546d2612/dgg02tq-65e09ba6-f27d-4360-9d11-e593d8e13528.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzcyMjlkMzkzLWMzYjgtNDcwMy1hNDFlLWU4NzY1NDZkMjYxMlwvZGdnMDJ0cS02NWUwOWJhNi1mMjdkLTQzNjAtOWQxMS1lNTkzZDhlMTM1MjguanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.DaSdzsJPrHoogbtyWZSgs0XX9m7bsO1M5es-RzOGu8s"},
                new Movies { Name = "Napoleón", MovieTime = new TimeSpan(2, 38, 0), Image = "https://hips.hearstapps.com/hmg-prod/images/napoleon-poster-64ad1f6325a8b.jpg?resize=980:*"}
        };
    }
}