using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExerciceSynthese
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			lblDate.Text = DateTime.Today.ToShortDateString();
			List<Tache> taches = new List<Tache>();
			taches = new TacheDal().SelectAll();
			lstTaches.ItemsSource = taches;
		}

		private void btnAdd_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new AddTache());
		}

        private void btnAccount_Clicked(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new Account());
		}

        private void lstTaches_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }
}
