namespace Cinepolis.Views;
using Cinepolis.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

public partial class SelectSnacks : ContentPage
{
    public ObservableCollection<Snacks> Snacks { get; set; } = new ObservableCollection<Snacks>();

    public SelectSnacks()
	{
		InitializeComponent();
        AddSnacks();
        BindingContext = this;
    }

    private void AddSnacks()
    {
        Snacks.Add(new Snacks { Name = "Combo Palomitas + 2 Refrescos", Description = "Palomitas de maíz + dos refrescos", Price = "L. 120", Image = "combo1.png" });
        Snacks.Add(new Snacks { Name = "Combo Palomitas + 1 Refresco", Description = "Palomitas de maíz + un refresco", Price = "L. 95", Image = "combo2.png" });
        Snacks.Add(new Snacks { Name = "Combo Nachos + 1 Refresco", Description = "Nachos + un refresco", Price = "L. 100", Image = "https://cuponassets.cuponatic-latam.com/backendMx/uploads/imagenes_descuentos/99307/6f86a091b0028c31a012a139722ab48e471973b2.XL2.jpg" });
        Snacks.Add(new Snacks { Name = "Refresco Adicional", Description = "Refresco adicional", Price = "L. 35", Image = "https://static.cinepolis.com/marcas/dulceria/imagenes/productos/9/20179810274538.png" });
    }

    public ICommand AddItemCommand => new Command<Snacks>(AddItem);
    public ICommand RemoveItemCommand => new Command<Snacks>(RemoveItem);

    private void AddItem(Snacks snack)
    {
        snack.Quantity++;
        Debug.WriteLine($"Uno mas - Cantidad: {snack.Quantity}");
        OnPropertyChanged(nameof(Snacks));

    }

    private void RemoveItem(Snacks snack)
    {
        Debug.WriteLine($"No resta pero se manda a llamar al metodo: {snack.Quantity}");

        if (snack.Quantity > 0)
        {

            snack.Quantity--;
            Debug.WriteLine($"Uno menos - Cantidad: {snack.Quantity}");
            OnPropertyChanged(nameof(Snacks));

        }
    }

    private async void SiguienteClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PayPage());
    }
}