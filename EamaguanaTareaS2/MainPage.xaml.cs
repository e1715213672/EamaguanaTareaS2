using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EamaguanaTareaS2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIniciarsesion_Clicked(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario== "estudiante2022" && contrasena== "uisrael2022")
            { 
                await Navigation.PushAsync(new Notas()); 
            }

            else
            { 
                DisplayAlert("Alerta", "Credenciales no validas", "Aceptar");
            }



        }
    }
}
