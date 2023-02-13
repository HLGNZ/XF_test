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
    public partial class Control : ContentPage
    {
        public Control()
        {

            InitializeComponent();
        }
        NumberCode numberCode;
        public Control(NumberCode numberCode)
        {
            
            InitializeComponent();
            ControlPage.Text = lang.Resource.ControlPage;
            Create.Text = lang.Resource.Create;
            Update.Text = lang.Resource.Update;
            Delete.Text = lang.Resource.Delete;
            this.numberCode = numberCode;
            Number.Text = numberCode.Number;
            Code.Text = numberCode.Code;
        }
        private async void Create_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Number.Text) && !string.IsNullOrEmpty(Code.Text))
            {
                NumberCode numberCode = new NumberCode()
                {
                    Number = Number.Text,
                    Code = Code.Text,
                };

                await App.SQliteHelper.SaveUsersAsync(numberCode);
                await DisplayAlert("Added", "your information are added", "OK");
                await Navigation.PopAsync();

            }
            else
            {
                await DisplayAlert("Error!!", "Number Or Code is empty", "OK");

            }
        }

        private async void Update_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Number.Text) && !string.IsNullOrEmpty(Code.Text))
            {
                NumberCode numberCode = await App.SQliteHelper.GetUsersByUser(Number.Text);

                if (numberCode != null)
                {
                    if (numberCode != null)
                    {

                        numberCode.Number = Number.Text;
                        numberCode.Code = Code.Text;
                    }
                    await App.SQliteHelper.SaveUsersAsync(numberCode);
                    await DisplayAlert("Sucsess", "your update is DONE", "OK");

                    await Navigation.PushAsync(new Login_Page());
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

        private async void back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var resp = await DisplayAlert("Warning!", "Are You Sure You Want To Delete This Number & Code ?", "Yes", "No");
            if (resp)
            {
                NumberCode numberCode = await App.SQliteHelper.GetUsersLoginAsync(Number.Text, Code.Text);

                await App.SQliteHelper.DeleteNumberAsync(numberCode);
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}