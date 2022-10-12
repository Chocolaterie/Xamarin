using EniDemo.Models;
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
    public partial class DemoPolymorphism : ContentPage
    {
        public DemoPolymorphism()
        {
            InitializeComponent();

            Article article = new Article { Title = "Crevette Nutella" };
            Person personne = new Person { Firstname = "Homme dans l'eau" };

            List<object> ObjectList = new List<object>();

            // Ajouter article et personne dans le même liste
            ObjectList.Add(article);
            ObjectList.Add(personne);

            foreach (object something in ObjectList){

                Article _article = (Article) something;
                
                Console.WriteLine("OBJECT TEST : " + something);
            }

        }
    }
}