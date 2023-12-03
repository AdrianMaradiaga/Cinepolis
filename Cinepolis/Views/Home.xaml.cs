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
                new Peliculas {
                    Titulo = "The Marvels",
                    Duracion = "1h 45m",
                    Sinopsis = "La Capitana Marvel ha recuperado su identidad y se ha vengado de la Inteligencia Suprema. Cuando sus deberes la envían a un agujero de gusano, sus poderes se enredan con los de otros dos superhéroes para formar a los Marvel.",
                    RutaImagenP = "https://m.media-amazon.com/images/M/MV5BM2U2YWU5NWMtOGI2Ni00MGMwLWFkNjItMjgyZWMxNjllNTMzXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg",
                    RutaImagenB = "https://www.koimoi.com/wp-content/new-galleries/2023/09/brie-larsons-the-marvels-breaks-record-for-being-the-cheapest-film-in-mcu-history-is-the-superhero-fatigue-making-marvel-cut.jpg",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"},
                new Peliculas {
                    Titulo = "Trolls 3",
                    Duracion = "1h 31m",
                    Sinopsis = "Poppy y Branch se convierten en pareja (#broppy) y mientras se acercan, Poppy descubre el pasado secreto de Branch. Él solía formar parte de la boyband BroZone con sus hermanos: Floyd, John Dory, Spruce y Clay. La banda y la familia se separaron cuando Branch era bebé y no ha visto a sus hermanos desde entonces. Cuando Floyd es secuestrado por las maléficas estrellas del pop Velvet y Veneer, Branch y Poppy se embarcan en un emocionante viaje para reunir a la familia y rescatar a Floyd.",
                    RutaImagenP = "https://www.dreamworks.com/storage/cms-uploads/trolls-band-together-poster-thumbnail.jpg",
                    RutaImagenB = "https://ntvb.tmsimg.com/assets/p24385182_v_h8_af.jpg?w=1280&h=720",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"},
                new Peliculas {
                    Titulo = "El Justiciero 3",
                    Duracion = "2h 21m",
                    Sinopsis = "El ex agente Robert McCall se encuentra en el sur de Italia y pronto descubre que sus nuevos amigos están bajo el control de los jefes del crimen local. Cuando los acontecimientos se vuelven mortales, McCall se convierte en su protector.",
                    RutaImagenP = "https://uip.com.co/wp-content/uploads/2023/05/El-Justiciero-capitulo-final-pelicula-estreno-poster-1.webp",
                    RutaImagenB = "https://www.infobae.com/new-resizer/3JWwLcA91aZKM9gyj1w3NkOilsE=/1200x630/filters:format(webp):quality(85)/cloudfront-us-east-1.images.arcpublishing.com/infobae/DOHNMN3MRVDPXKBEOFDQAVDIEQ.jpg",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"},
                new Peliculas {
                    Titulo = "Los Juegos del Hambre: balada",
                    Duracion = "2h 38m",
                    Sinopsis = "Para demostrar su poder, el régimen del estado totalitario de Panem organiza cada año \"Los juegos del hambre\". En ellos, 24 jóvenes compiten el uno contra el otro en una batalla en la que solo puede haber un superviviente. La joven Katniss se ofrece voluntaria para participar en los juegos para salvar a su hermana. Junto a ella participará Peeta, un joven al que ha conocido desde la infancia y que está enamorado de ella. Sin embargo, el Capitolio quiere convertirlos en contrincantes.",
                    RutaImagenP = "https://cdn.hobbyconsolas.com/sites/navi.axelspringer.es/public/media/image/2023/09/poster-juegos-hambre-balada-pajaros-cantores-serpientes-3143194.jpg?tf=3840x",
                    RutaImagenB = "https://cdn.hobbyconsolas.com/sites/navi.axelspringer.es/public/media/image/2023/09/juegos-hambre-balada-pajaros-cantores-serpientes-2023-3143164.jpg?tf=3840x",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"},
                new Peliculas {
                    Titulo = "Five Nights at Freddy's",
                    Duracion = "1h 49m",
                    Sinopsis = "Un problemático guardia de seguridad empieza a trabajar en la pizzería Freddy Fazbear's. Mientras pasa su primera noche en el trabajo, se da cuenta de que el turno de noche en Freddy's no será tan fácil de sobrellevar.",
                    RutaImagenP = "https://img.aullidos.com/imagenes/caratulas/five-nights-freddys-poster-sp-2.jpg",
                    RutaImagenB = "https://i.ytimg.com/vi/0VH9WCFV6XQ/maxresdefault.jpg",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"}
            };
        Movie2 = new ObservableCollection<Peliculas>
            {
                new Peliculas {
                    Titulo = "Viernes Negro",
                    Duracion = "1h 46m",
                    Sinopsis = "Después de que un disturbio termina en tragedia en el Viernes Negro, un misterioso asesino inspirado en el Día de Acción de Gracias aterroriza Plymouth Massachusetts–el lugar donde nació esa festividad(norteamericana).",
                    RutaImagenP = "https://uip.com.co/wp-content/uploads/2023/09/Viernes-negro-pelicula-estreno-poster.webp",
                    RutaImagenB = "https://i.ytimg.com/vi/1keSRyipyac/maxresdefault.jpg",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"},
                new Peliculas {
                    Titulo = "Wonka",
                    Duracion = "1h 56m",
                    Sinopsis = "La historia se centra en el joven Willy Wonka y en cómo conoció a los Oompa-Loompas en una de sus primeras aventuras.",
                    RutaImagenP = "https://deadline.com/wp-content/uploads/2023/11/WONKA_INSTA_VERT_MAIN_1638x2048_DOM.jpg?w=800",
                    RutaImagenB = "https://www.showmetech.com.br/wp-content/uploads//2023/10/cappa.png",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"},
                new Peliculas {
                    Titulo = "Wish: el poder de los deseos",
                    Duracion = "1h 35m",
                    Sinopsis = "Asha y una pequeña bola de energía ilimitada llamada Star demuestran que cuando la voluntad de un ser humano valiente se conecta con la magia de las estrellas, pueden suceder cosas maravillosas.",
                    RutaImagenP = "https://preview.redd.it/official-poster-for-disneys-wish-v0-lx37p7pymtqb1.jpg?auto=webp&s=abc51673c574fd3a95870999bf979365e00a9650",
                    RutaImagenB = "https://nosomosnonos.com/wp-content/uploads/2023/09/1463c0cc393384298cf7dfe1b10b7ba9.jpg",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"},
                new Peliculas {
                    Titulo = "Aquaman 2",
                    Duracion = "1h 55m",
                    Sinopsis = "Aquaman forja una alianza incómoda con un aliado poco probable para salvar a Atlantis y al resto del planeta de la muerte inminente.",
                    RutaImagenP = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/7229d393-c3b8-4703-a41e-e876546d2612/dgg02tq-65e09ba6-f27d-4360-9d11-e593d8e13528.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzcyMjlkMzkzLWMzYjgtNDcwMy1hNDFlLWU4NzY1NDZkMjYxMlwvZGdnMDJ0cS02NWUwOWJhNi1mMjdkLTQzNjAtOWQxMS1lNTkzZDhlMTM1MjguanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.DaSdzsJPrHoogbtyWZSgs0XX9m7bsO1M5es-RzOGu8s",
                    RutaImagenB = "https://i.blogs.es/8d6d15/aquaman/1366_2000.jpeg",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"},
                new Peliculas {
                    Titulo = "Napoleón",
                    Duracion = "2h 38m",
                    Sinopsis = "Una mirada a los orígenes del comandante militar y su rápido y despiadado ascenso a emperador, visto a través del prisma de su adictiva y a menudo volátil relación con su esposa y único amor verdadero, Josefina.",
                    RutaImagenP = "https://hips.hearstapps.com/hmg-prod/images/napoleon-poster-64ad1f6325a8b.jpg?resize=980:*",
                    RutaImagenB = "https://www.napoleon.movie/images/share.jpg",
                    Horario1 = "3:00 PM",
                    Horario2 = "5:00 PM",
                    Horario3 = "7:00 PM"}
            };
    }

    public async void OnCarouselItemTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MovieDetailPage());
    }
}