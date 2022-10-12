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

        public TwitterPage()
        {

            InitializeComponent();
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

            // Si formulaire valide
            if (formResult.Validate())
            {
                // Caché le formulaire et afficher le tweet
                this.tweetDiv.IsVisible = true;
                this.loginForm.IsVisible = false;
            }
            // Sinon erreur
            else
            {
                this.errorLabel.Text = formResult.GetMessageError();
            }
        }
    }
}