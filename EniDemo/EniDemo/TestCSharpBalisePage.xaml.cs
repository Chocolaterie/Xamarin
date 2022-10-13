using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EniDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestCSharpBalisePage : ContentPage
    {
        public TestCSharpBalisePage()
        {
            InitializeComponent();

           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Ajouter un label dans le root comp (xname d'un stack layout)
            this.RootComp.Children.Add(new Label { Text = "Test" });

            // Créer dans la mémoire un stacklayout
            StackLayout stackLayoutTest = new StackLayout {
                Children =
                {
                    new Label { Text="Ligne 1"},
                    new Button { Text="Bouton test"},
                    new Label { Text = "Ligne 3", Padding = new Thickness(5, 5) },
                    new Label {Text = "Ligne 4" , TextColor = Color.FromHex("#FF55CC")}
                }
            };

            // Ajouter dans le root comp
            this.RootComp.Children.Add(stackLayoutTest);
        }
    }
}