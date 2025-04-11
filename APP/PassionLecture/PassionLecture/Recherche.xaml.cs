using Microsoft.Maui.Controls.Shapes;
using System.Collections.ObjectModel;

namespace PassionLecture.View;

public partial class Recherche : ContentPage
{
    public ObservableCollection<Livre> Livres { get; set; }
    public Recherche()
	{

		InitializeComponent();
        Livres = new ObservableCollection<Livre>
        {
            new Livre { Titre = "Livre 1" },
            new Livre { Titre = "Livre 2" },
            new Livre { Titre = "Livre 3" },
            new Livre { Titre = "Livre 4" }
        };

        BindingContext = this;
    }
}
public class Livre
{
    public string Titre { get; set; }
   
}