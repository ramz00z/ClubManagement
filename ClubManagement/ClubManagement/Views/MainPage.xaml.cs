using ClubManagement.ViewModel;
using ClubManagement.Views;

using Xamarin.Forms;

namespace ClubManagement
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            PresidentButton.Clicked += (sender, args) => { Navigation.PushAsync(new PresidentPage()); };

            CoachButton.Clicked += (sender, args) => { Navigation.PushAsync(new CoachPage(new ScheduleListViewModel())); };
        }
    }
}
