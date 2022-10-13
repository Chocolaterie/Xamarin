using EniDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EniDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayoutPage : ContentPage
    {
        ObservableCollection<Person> persons;

        public GridLayoutPage()
        {
            InitializeComponent();

            // Liste vide
            persons = new ObservableCollection<Person>();

            // Données mock (alimenter la liste)
            for (int i = 0; i < 10; i++)
            {
                persons.Add(new Person { Firstname = $"Pierre{i}" });
            }
            // Lier la liste de donnée avec la ListView
            this.ListViewPerson.ItemsSource = persons;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            persons.Add(new Person { Firstname = "Hugo"});

            persons[2].Firstname = "Bruit de claque";
            persons[2] = persons[2];
            //await Navigation.PushAsync(new TwitterPage());
        }
    }
}