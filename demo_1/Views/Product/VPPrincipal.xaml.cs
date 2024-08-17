using demo_1.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo_1.Views.Product
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VPPrincipal : ContentPage
    {
        public VPPrincipal()
        {
            InitializeComponent();
        }

        private async void btnSumar_Clicked(object sender, EventArgs e)
        {
            string usuario = "admin";
            string pass = "admin";

            string usuario_ingresado=txtvalor1.Text;
            string contrasenia_ingresado = txtvalor2.Text;
            if (usuario == usuario_ingresado && pass == contrasenia_ingresado)
            {
                await Navigation.PushModalAsync(new VHPrincipal());
            }
            else
            {
                lblResulado.Text = "Incorrecto hacker!";
            }
            
            /*int valor1 = int.Parse(txtvalor1.Text);
            int valor2 = int.Parse(txtvalor2.Text);
            int resultado = valor1 + valor2;
            lblResulado.Text = resultado.ToString();
            */
        }
    }
}