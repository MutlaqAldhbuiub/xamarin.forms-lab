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
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            back.Clicked += (s, e) => Environment.Exit(0);
            clear.Clicked += (s, e) => { firstName.Text = ""; passwordInput.Text = ""; };

            login.Text = Lang.Resource.Login;
            back.Text = login.Text = Lang.Resource.CLOSE;
            clear.Text = Lang.Resource.Clean;
        }

       private  void login_Clicked(object sender, EventArgs e)
        {
            String fn = firstName.Text;
            String password = passwordInput.Text;
            if (fn == "aa" && password == "matulkn"){
                 Navigation.PushAsync(new MainPage(fn));
            }
            else
            {
                 DisplayAlert("Alert", "You have been enterd wrong name and password", "OKAY!");
            }
        }
    }
}