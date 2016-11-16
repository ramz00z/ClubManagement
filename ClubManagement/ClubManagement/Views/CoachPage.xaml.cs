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

        public void OnModify(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var schedule = mi.CommandParameter as ScheduleViewModelBase;
            Navigation.PushModalAsync(new ModifySchedulePage(new ModifyScheduleViewModel
            {
                Id = schedule.Id,
                Title = schedule.Title,
                Team = schedule.Team,
                Type = schedule.Type,
                StartDateTime = schedule.StartDateTime,
                EndDateTime = schedule.EndDateTime
            }));
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }
    }
}
