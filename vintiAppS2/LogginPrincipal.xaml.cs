using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vintiAppS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogginPrincipal : ContentPage
    {
        public LogginPrincipal()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text;
            if ((usuario == "estudiante2021") && (contraseña == "uisrael2021"))
            {
                await Navigation.PushAsync(new MainPage(usuario, contraseña));

            }
            else
            {
                lblMensaje.Text = "El usuario o password son incorrectos";
            }
            
            
        }
    }
}