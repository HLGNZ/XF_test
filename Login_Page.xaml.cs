using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_144310_AhmadAlhrthi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login_Page : ContentPage
    {
        public Login_Page()
        {
            InitializeComponent();

            Login.Text = lang.Resource.Login;
            Home.Text = lang.Resource.Home;
            LoginPage.Text = lang.Resource.LoginPage;
            Number.Text = lang.Resource.Number;
            Code.Text = lang.Resource.Code;


        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Number.Text) && !string.IsNullOrEmpty(Code.Text))
            {
                NumberCode numberCode = await App.SQliteHelper.GetUsersLoginAsync(Number.Text, Code.Text);
                
                if (numberCode != null)
                {
                    await Navigation.PushAsync(new FainalPage(numberCode));
                }
                else
                {
                    await DisplayAlert("Error !!", "Number or Code not found ", "OK");
                }

            }
            else
            {
                await DisplayAlert("Error !!", "Number or Code is Empty", "OK");
            }
        }

        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}