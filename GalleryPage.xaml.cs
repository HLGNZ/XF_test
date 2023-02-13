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
    public partial class GalleryPage : CarouselPage
    {
        public GalleryPage()
        {
            InitializeComponent();
            Back.Text = lang.Resource.Back;

            Back.Clicked += (s,e) => Navigation.PopAsync();

            book1.Source = ImageSource.FromUri(new Uri("https://pngimage.net/wp-content/uploads/2019/05/ranch-house-png-3.jpg"));
            book2.Source = ImageSource.FromUri(new Uri("https://pngimage.net/wp-content/uploads/2018/06/row-of-houses-png-.png"));
            book3.Source = ImageSource.FromUri(new Uri("https://pngimage.net/wp-content/uploads/2018/06/png-houses-for-sale-4-300x200.png"));
        }
    }
}