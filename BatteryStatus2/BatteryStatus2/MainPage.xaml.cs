using DependencyServiceSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BatteryStatus2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            
        }

        private void btnGet_Clicked(object sender, EventArgs e)
        {
            var data = DependencyService.Get<IData>().GetData(txtUserName.Text);

            DisplayAlert("Hello", data.ToString(), "Cancel");

        }
    }
}
