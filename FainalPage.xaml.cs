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
    public partial class FainalPage : ContentPage
    {
        NumberCode numberCode;
        public FainalPage(NumberCode numberCode)
        {
            InitializeComponent();
            this.numberCode = numberCode;
        }
        protected override  void OnAppearing()
        {
            number.Text = numberCode.Number;
            code.Text = numberCode.Code;
        
        }

      

        private async void ControlPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Control(numberCode));
        }

        private async void LOGOUTE_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void AllUsers_Clicked(object sender, EventArgs e)
        {
          //  var details = await App.SQliteHelper.GetUsersAsync();

            var details = await App.SQliteHelper.GetUsersAsync();
            allInfo.ItemsSource = details;
        }
    }
}