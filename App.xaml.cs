using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_144310_AhmadAlhrthi
{
    public partial class App : Application
    {
        static Operations dp;

        public static Operations SQliteHelper
        {
            get
            {
                if (dp == null)
                {
                    dp = new Operations(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NumberCodeOperation.dp7"));
                }

                return dp;
            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
