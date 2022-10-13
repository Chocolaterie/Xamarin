using EniDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EniDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoServicePage : ContentPage
    {
        public DemoServicePage()
        {
            InitializeComponent();

            // On récupère le singleton du service IDeviceOrientation selon la plateforme lancée
            IDeviceOrientation deviceOrientation = DependencyService.Get<IDeviceOrientation>();

            // Récupérer l'orientation du téléphone
            DeviceOrientations Orientation = deviceOrientation.GetOrientation();

            Console.WriteLine($"Orientation du tel : {Orientation}");

        }
    }
}