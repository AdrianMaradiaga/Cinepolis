using LiteDB;
using Firebase.Database;
using Cinepolis.Models;
using System.Collections.ObjectModel;

namespace Cinepolis.Views;

public partial class MoviesPage : ContentPage
{
    FirebaseClient client = new FirebaseClient("https://cinepolis-d5adc-default-rtdb.firebaseio.com/");
    public ObservableCollection<Peliculas> Lista { get; set; } = new ObservableCollection<Peliculas>();

    public MoviesPage()
    {
        InitializeComponent();
        BindingContext = this;
        CargaLista();
    }

    public void CargaLista()
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
    }
}