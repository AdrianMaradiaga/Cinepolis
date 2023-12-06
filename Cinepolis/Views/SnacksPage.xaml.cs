using System.Collections.ObjectModel;
using Cinepolis.Models;
using Firebase.Database;

namespace Cinepolis.Views;

public partial class SnacksPage : ContentPage
{
    FirebaseClient client = new FirebaseClient("https://cinepolis-d5adc-default-rtdb.firebaseio.com/");
    public ObservableCollection<Snacks> ListaSnacks { get; set; } = new ObservableCollection<Snacks>();

    public SnacksPage()
    {
        InitializeComponent();
        CargarListaSnacks();
        BindingContext = this;
    }

    private void CargarListaSnacks()
    {
        client.Child("Snacks")
                .AsObservable<Snacks>()
                .Subscribe(Snacks =>
                {
                    if (Snacks != null && Snacks.Object != null)
                    {
                        ListaSnacks.Add(Snacks.Object);
                    }
                });
    }
}