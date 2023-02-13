using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_144310_AhmadAlhrthi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoginPage.Text = lang.Resource.LoginPage;
            ControlPage.Text= lang.Resource.ControlPage;
            GalleryPage.Text= lang.Resource.GalleryPage;
            close.Text=lang.Resource.close;
            HomePPage.Text= lang.Resource.HomePPage;
        }

        private async void LoginPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login_Page());
            
        }

        private async void GalleryPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage());
            
        }

        private async void ControlPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Control());
        }

        private void close_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
