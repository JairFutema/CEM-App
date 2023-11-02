using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CEM_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Administrador_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Administrador());
        }
        private async void PerfilAdmi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfil_Administrador());
        }

    }
}
