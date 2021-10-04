using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Text.RegularExpressions;

namespace FDP
{
    public partial class MainPage : ContentPage
    {
        public MainPage(String username)
        {
            InitializeComponent();
            usernameLabel.Text = "@" + username;
            clear.Clicked += (s, e) =>
            {
                myinfo.Text = "";
            };
        }

        private async void movePage_Clicked(object sender, EventArgs e)
        {
            if(myinfo.Text == "" || myinfo.Text == null)
            {
                await DisplayAlert("Alert", "You're information cannot be null!", "OKAY!");
            }
            else { 
                await Navigation.PushAsync(new ScreenPage(usernameLabel.Text,myinfo.Text));
            }
        }

        private async void logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void callMe_Clicked(object sender, EventArgs e)
        {
            if (myinfo.Text == "" || myinfo.Text == null)
            {

                PhoneDialer.Open("+966541770361");
            }
            else {
                // Define a regular expression for repeated words.
                Regex rx = new Regex(@"(\+[0-9])\w+",
                  RegexOptions.Compiled | RegexOptions.IgnoreCase);
                if (rx.IsMatch(myinfo.Text))
                {
                    PhoneDialer.Open(myinfo.Text);
                }
                else
                {
                    await DisplayAlert("Alert", "That's not a vaild phone number", "OKAY!");
                }
               
            }
        }

        private async void webBrowser_Clicked(object sender, EventArgs e)
        {
            if (myinfo.Text == "" || myinfo.Text == null || string.IsNullOrEmpty(myinfo.Text) || string.IsNullOrWhiteSpace(myinfo.Text)){
                await DisplayAlert("Alert", "You must enter a url, It cannot be null!", "OKAY!");
            }else{
                await Browser.OpenAsync(new Uri(myinfo.Text), BrowserLaunchMode.SystemPreferred);
            }
        }

        private void rotateButton_Clicked(object sender, EventArgs e)
        {
            rotateLabel.RotateTo(180, 3000);
        }
    }
}
