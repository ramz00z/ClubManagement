using ClubManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ClubManagement.Views
{
    public partial class AddSchedulePage : ContentPage
    {
        public AddSchedulePage()
        {
            InitializeComponent();

            Title = "Ajouter un horaire";
        }

        public AddSchedulePage(ScheduleListViewModel slvm) : this()
        {
            Content.BindingContext = new AddScheduleViewModel(slvm);
        }
    }
}
