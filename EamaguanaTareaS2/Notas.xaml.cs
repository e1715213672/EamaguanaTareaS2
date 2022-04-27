using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EamaguanaTareaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnNotaFinal_Clicked(object sender, EventArgs e)
        {

            try
            {

                double seguimiento1 = Convert.ToDouble(txtSeguimiento1.Text);
                double examen1 = Convert.ToDouble(txtExamen1.Text);
                double parcial1 = seguimiento1 * 0.3 + examen1 * 0.2;

                lblParcial1.Text = parcial1.ToString();
                
                double seguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
                double examen2 = Convert.ToDouble(txtExamen2.Text);
                double parcial2 = seguimiento2 * 0.3 + examen2 * 0.2;

                lblParcial2.Text = parcial2.ToString();

                lblFinal.Text= (parcial1+parcial2).ToString();



            }
            catch (Exception ex)
            {

                DisplayAlert("ERROR", ex.Message, "Cerrar"); ;
            }
            
        }
    }
}