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
    public partial class ListViewPage : ContentPage
    {
        ObservableCollection<Person> PersonList;

        public ListViewPage()
        {
            InitializeComponent();

            PersonList = new ObservableCollection<Person>();

            PersonList.Add(new Person { Firstname = "Isaac" });
            PersonList.Add(new Person { Firstname = "Hugo" });
            PersonList.Add(new Person { Firstname = "Test" });

            this.personView.ItemsSource = PersonList;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PersonList[1].Firstname = "CHOCOLATINE";
            PersonList[1] = PersonList[1];
        }
    }
}