using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavToPage1_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["SomeText"] = PassValue.Text;
            Navigation.PushAsync(new Page1());
        }
    }
}
