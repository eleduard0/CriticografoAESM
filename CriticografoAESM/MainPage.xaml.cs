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
            string genero = Hombre.IsChecked ? "Masculino" : "Femenino";
            string submensaje = "";
            List<string> opcionesSeleccionadas = new List<string>();
            if (Alto.IsChecked) 
            {
                opcionesSeleccionadas.Add("Alto");
            }
            if (Feo.IsChecked) 
            {
                opcionesSeleccionadas.Add("Feo");
            }
            if (Listo.IsChecked) 
            {
                opcionesSeleccionadas.Add("Listo");
            }
            if (pirata.IsChecked) 
            {
                opcionesSeleccionadas.Add("Extravagante");
            }
            if (Raro.IsChecked) 
            {
                opcionesSeleccionadas.Add("Raro");
            }
            if (Grande.IsChecked) 
            {
                opcionesSeleccionadas.Add("Grande");
            }
            if (opcionesSeleccionadas.Count > 0)
            {
                
                for (int i = 0; i < opcionesSeleccionadas.Count; i++)
                {
                    string opcion = opcionesSeleccionadas[i];

                    if (opcion.EndsWith("o"))
                    {
                        if (genero == "Femenino")
                        {
                            opcion = opcion.Substring(0, opcion.Length - 1) + "a";
                        }
                    }
                    opcionesSeleccionadas[i] = opcion;
                }
                submensaje = string.Join(", ", opcionesSeleccionadas.Take(opcionesSeleccionadas.Count - 1));
                submensaje += " y " + opcionesSeleccionadas.Last();
            } 
            string mensaje = $"{Nombre.Text} es {submensaje}.";
            Mensaje.Text = mensaje;
        }
    }
}
