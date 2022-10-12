using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace EniDemo
{
    public class FormFieldConfig
    {
        public Int32 MinLength;
        public String EntryName;
        public string ErrorMesssage;

        public String GetErrorMessage()
        {
            // $"Veuillez entrer un {EntryName} d'au moins {MinLength} caractères";
            Dictionary<string, string> _parameters = new Dictionary<string, string>();
           
            _parameters.Add(@"{name}", EntryName);
            _parameters.Add(@"{length}", MinLength.ToString());


            return _parameters.Aggregate(ErrorMesssage, (s, kv) => s.Replace(kv.Key, kv.Value)); ;
        }
     
    }

    public class FormResult
    {

        public List<String> ErrorList { get; set; }

        public Dictionary<Entry, FormFieldConfig> FieldConfigs;

        public FormResult(Dictionary<Entry, FormFieldConfig> _fieldConfigs)
        {
            FieldConfigs = _fieldConfigs;
            ErrorList = new List<String>();
        }

        public void AddError(String error)
        {
            ErrorList.Add(error);
        }

        public bool Validate()
        {
            foreach (Entry entry in FieldConfigs.Keys){

                FieldConfigs.TryGetValue(entry, out FormFieldConfig FormField);

                // Si champ valide
                if (String.IsNullOrWhiteSpace(entry.Text) || entry.Text.Length < FormField.MinLength)
                {
                    // Ajouter message erreur
                    AddError(FormField.GetErrorMessage());
                }
            }

            // Si j'ai plus d'une erreur alors le formulaire est invalide
            if (ErrorList.Count > 0)
            {
                return false;
            }

            return true;
        }

        public String GetMessageError()
        {
            return String.Join("\n", ErrorList);
        }
    }
}
