

using LiteDB;
using Firebase.Database;
using Cinepolis.Models;
using System.Collections.ObjectModel;

namespace Cinepolis.Views;

public partial class MoviesPage : ContentPage
{
    FirebaseClient client = new FirebaseClient("https://prueba-5d6e8-default-rtdb.firebaseio.com/");
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
                if (Peliculas != null)
                {
                    Lista.Add(Peliculas.Object);
                }
            });
    }


    private void filtroEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string filtro = filtroEntry.Text.ToLower();
        if (filtro.Length > 0)
        {
            listaPeliculas.ItemsSource = Lista.Where(X => X.Nombre.ToLower().Contains(filtro)).ToList();
        }
        else
        {

            listaPeliculas.ItemsSource = Lista.ToList();
        }
    }
}