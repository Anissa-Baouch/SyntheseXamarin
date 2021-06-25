using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciceSynthese
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Account : ContentPage
    {
        private Profil profilGeneral;
        public Account()
        {
            InitializeComponent();
            profilGeneral = new ProfilDal().Select(1);
            if(profilGeneral != null)
            {
                entNom.Text = profilGeneral.Nom;
                entPrenom.Text = profilGeneral.Prenom;
                entAge.Text = profilGeneral.Age.ToString();
                
            }

        }

        private void btnValid_Clicked(object sender, EventArgs e)
        {
            if (profilGeneral != null)
                profilGeneral = new Profil();
            profilGeneral.Nom = entNom.Text;
            profilGeneral.Prenom = entPrenom.Text;
            profilGeneral.Age = Convert.ToInt32(entAge);
            new ProfilDal().Sauvegarder(profilGeneral);
        }

        private void btnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}