using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace toMaatti
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void nappiaPainettu(object sender, EventArgs e)
        {
            Ajastin.aloitaAjastus();
        }
    }

    public static class Ajastin
    {
        public static System.Timers.Timer tomaattiAjastin;
        public static void aloitaAjastus()
        {
            tomaattiAjastin = new System.Timers.Timer(1000);

        }
    }
}
