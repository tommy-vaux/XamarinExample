using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
        // Learn more about making custom code visible in the Xamarin.Forms previewer
        // by visiting https://aka.ms/xamarinforms-previewer
        [DesignTimeVisible(false)]
        public partial class MainPage : ContentPage
        {
                public MainPage()
                {
                        InitializeComponent();
                }

                int count = 0;
                void Open_Door(object sender, System.EventArgs e)
                {
                        count++;
                        ((Button)sender).Text = "Door should open. Button Clicked {count} times.";
                }
        }
}
