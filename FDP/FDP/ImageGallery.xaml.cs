using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FDP
{
    [DesignTimeVisible(false)]

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageGallery : CarouselPage
    {
        public ImageGallery()
        {
            InitializeComponent();
            Dice1.Source = ImageSource.FromUri(new Uri("https://cdn.pixabay.com/photo/2017/01/08/13/58/cube-1963036__340.jpg"));
            Dice2.Source = ImageSource.FromUri(new Uri("https://cdn.pixabay.com/photo/2016/07/07/16/46/dice-1502706__340.jpg"));
            Dice3.Source = ImageSource.FromUri(new Uri("https://cdn.pixabay.com/photo/2016/09/08/18/45/cube-1655118__340.jpg"));
            Dice4.Source = ImageSource.FromUri(new Uri("https://cdn.pixabay.com/photo/2012/04/05/01/24/dice-25637__340.png"));
            Dice5.Source = ImageSource.FromFile("C:/Users/S/Pictures/splash_logo.png");

            LDice1.Text = Lang.Resource.LDice1;
            LDice1.Text = Lang.Resource.LDice2;
        }
    }
}