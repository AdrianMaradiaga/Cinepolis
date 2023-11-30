using System.Collections.ObjectModel;
using Cinepolis.Models;
namespace Cinepolis.Views;

public partial class SnacksPage : ContentPage
{
    public ObservableCollection<Snacks> Snacks { get; set; } = new ObservableCollection<Snacks>();

    public SnacksPage()
	{
		InitializeComponent();
        AddSnacks();
        BindingContext = this;
    }

    private void AddSnacks()
    {
        Snacks.Add(new Snacks { Name = "Combo Palomitas + 2 Refrescos", Description = "Palomitas de maíz + dos refrescos", Price = "L. 120", Image = "https://static.promodescuentos.com/threads/raw/default/667189_1/re/1024x1024/qt/60/667189_1.jpg" });
        Snacks.Add(new Snacks { Name = "Combo Palomitas + 1 Refresco", Description = "Palomitas de maíz + un refresco", Price = "L. 95", Image = "https://cuponassets.cuponatic-latam.com/backendMx/uploads/imagenes_descuentos/96808/e2d26e632df2f957c70840e07a2d0461a560ed40.XL2.jpg" });
        Snacks.Add(new Snacks { Name = "Combo Nachos + 1 Refresco", Description = "Nachos + un refresco", Price = "L. 100", Image = "https://cuponassets.cuponatic-latam.com/backendMx/uploads/imagenes_descuentos/99307/6f86a091b0028c31a012a139722ab48e471973b2.XL2.jpg" });
        Snacks.Add(new Snacks { Name = "Refresco Adicional", Description = "Refresco adicional", Price = "L. 35", Image = "https://static.cinepolis.com/marcas/dulceria/imagenes/productos/9/20179810274538.png" });
    }
}