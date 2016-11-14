using ClubManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ClubManagement.Views
{
    public partial class CoachPage : ContentPage
    {
        public CoachPage()
        {
            InitializeComponent();

            Title = "Coach";

            AddScheduleButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new AddSchedulePage((ScheduleListViewModel)(Content.BindingContext)));
            };
        }
    }
}
