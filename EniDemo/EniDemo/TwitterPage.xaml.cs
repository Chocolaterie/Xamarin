using EniDemo.Models;
using EniDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EniDemo
{
    public partial class TwitterPage : ContentPage
    {

        ITwitterService TwitterService { get; set; }

        public TwitterPage()
        {
            InitializeComponent();

            // Instancier le twitter service mock
            TwitterService = new TwitterServiceMock();
        }

        private FormResult validateForm()
        {
            Dictionary<Entry, FormFieldConfig> FieldConfigs = new Dictionary<Entry, FormFieldConfig>
            {
                { this.emailEntry, new FormFieldConfig {
                    MinLength = 3,
                    EntryName = "Email",
                    ErrorMesssage = @"Veuillez entrer un {name} d'au moins {length} caractères",
                    } 
                },
                { this.passwordEntry,  new FormFieldConfig {
                    MinLength = 6,
                    EntryName = "Password",
                    ErrorMesssage = @"Please entry at least {length} char in {name}",
                }}
            };

            FormResult formResult = new FormResult(FieldConfigs);

            // Retourner le resultat
            return formResult;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            FormResult formResult = validateForm();

            // Si formulaire valide (contrôle de surface est ok
            if (formResult.Validate())
            {
                // Si le contrôle métier est aussi ok
                if (TwitterService.authenticate(this.emailEntry.Text, this.passwordEntry.Text))
                {
                    // Caché le formulaire et afficher le tweet
                    this.loginForm.IsVisible = false;

                    // Lier la liste de donnée avec la ListView
                    this.ListViewPerson.IsVisible = true;
                    this.ListViewPerson.ItemsSource = TwitterService.getTweets("");
                }
                else
                {
                    this.errorLabel.Text = "Couple email/mot de passe invalide";
                }
             
            }
            // Sinon erreur
            else
            {
                this.errorLabel.Text = formResult.GetMessageError();
            }
        }
    }
}