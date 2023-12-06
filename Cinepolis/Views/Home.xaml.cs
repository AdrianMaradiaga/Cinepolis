namespace Cinepolis.Views;
using Cinepolis.Models;
using Firebase.Database;
using System.Collections.ObjectModel;

public partial class Home : ContentPage
{
    FirebaseClient client = new FirebaseClient("https://cinepolis-d5adc-default-rtdb.firebaseio.com/");
    public ObservableCollection<Peliculas> Lista { get; set; } = new ObservableCollection<Peliculas>();
    public ObservableCollection<ProximosEstrenos> ListaEstrenos { get; set; } = new ObservableCollection<ProximosEstrenos>();
    public ObservableCollection<Cines> ListaCines { get; set; } = new ObservableCollection<Cines>();

    public List<string> Cines = new List<string>();
    public Cines CineSeleccionado { get; set; }

    public Home()
    {
        InitializeComponent();

        CargarListas();
        BindingContext = this;
    }

    private void CargarListas()
    {
        client.Child("Peliculas")
                 .AsObservable<Peliculas>()
                 .Subscribe(Peliculas =>
                 {
                     if (Peliculas != null && Peliculas.Object != null)
                     {
                         Lista.Add(Peliculas.Object);
                     }
                 });


        client.Child("ProximosEstrenos")
            .AsObservable<ProximosEstrenos>()
            .Subscribe(ProximosEstrenos =>
            {
                if (ProximosEstrenos != null && ProximosEstrenos.Object != null)
                {
                    ListaEstrenos.Add(ProximosEstrenos.Object);
                }
            });

        client.Child("Cines")
           .AsObservable<Cines>()
           .Subscribe(Cines =>
           {
               if (Cines != null && Cines.Object != null)
               {

                   ListaCines.Add(Cines.Object);
               }
           });
        pickerCines.ItemsSource = ListaCines;
    }



    public async void OnCarouselItemTapped(object sender, EventArgs e)
    {
        Peliculas p = carrusel1.CurrentItem as Peliculas;

        // Validar que se haya seleccionado un cine
        if (CineSeleccionado == null || string.IsNullOrEmpty(CineSeleccionado.Nombre))
        {
            await DisplayAlert("Error", "Por favor, selecciona un cine antes de elegir una película.", "OK");
            return;
        }

        // Obtener el cine seleccionado del Picker
        App.selecciones.Cine = CineSeleccionado.Nombre;
        App.selecciones.Titulo = p.Titulo;
        await Navigation.PushAsync(new MovieDetailPage(p));
    }
}