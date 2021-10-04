using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FDP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScreenPage : ContentPage
    {
        public ScreenPage(String username,String info)
        {
            InitializeComponent();
            myinfo.Text = info;

            close.Clicked += (s,e) => Environment.Exit(0);
        }

        private async void logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstPage());
        }

        private async void gallery_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageGallery());
        }
    }
}