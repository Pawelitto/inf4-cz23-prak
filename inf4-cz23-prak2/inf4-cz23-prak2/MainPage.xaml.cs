using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace inf4_cz23_prak2
{ 
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public int responseState = 0;
        public string[] responses = new string[] { "Dzień dobry", "Good Morning", "Buenos dias" };

        void slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            int intValueSlider = (int)slider.Value;

            sliderSize.Text = "Rozmiar: " + intValueSlider;
            response.FontSize = intValueSlider;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if(responseState != 2)
            {
                responseState += 1;
                response.Text = responses[responseState];
            } else
            {
                responseState = 0;
            }
            
        }
    }
}

