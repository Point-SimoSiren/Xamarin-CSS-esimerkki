using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CSSstylesXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void nappi_Clicked(object sender, EventArgs e)
        {
            if (teksti.Text != "Virta päällä!")
            {
                nappi.Background = Brush.Blue;
                teksti.Text = "Virta päällä!";
                teksti.TextColor = Color.Red;
            }
            else
            {
                nappi.Background = Brush.Red;
                teksti.Text = "Virta pois päältä!";
                teksti.TextColor = Color.Green;
            }
        }
    }
}
