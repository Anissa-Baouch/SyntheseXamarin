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
    public partial class AddTache : ContentPage
    {
        public AddTache()
        {
            InitializeComponent();
        }

        private void btnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void btnValid_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new AddTache());
        }
    }
}