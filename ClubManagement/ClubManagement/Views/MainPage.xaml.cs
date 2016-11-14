using ClubManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ClubManagement
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            PresidentButton.Clicked += (sender, args) => { Navigation.PushAsync(new PresidentPage()); };

            CoachButton.Clicked += (sender, args) => { Navigation.PushAsync(new CoachPage()); };
        }
    }
}
