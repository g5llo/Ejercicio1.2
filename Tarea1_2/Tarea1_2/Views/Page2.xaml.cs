using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1_2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        public Page2(String nombre, string apellido, string edad, string correo)
        {
            InitializeComponent();

            lbNombre.Text = nombre;
            lbApellido.Text = apellido;
            lbEdad.Text = edad;
            lbCorreo.Text = correo;
        }
    }
}