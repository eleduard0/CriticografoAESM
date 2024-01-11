using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CriticografoAESM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string mensaje;
            string genero;
            if (Hombre.IsChecked== true)
            {
                genero = "hombre";
            }
            else { genero = "mujer"; }

            

            Mensaje.Text = $"{Nombre.Text} es {genero}";
        }
    }
}
