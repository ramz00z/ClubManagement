using ClubManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ClubManagement.Views
{
    public partial class ModifySchedulePage : ContentPage
    {
        private ModifySchedulePage()
        {
            InitializeComponent();

            Title = "Modifier un horaire";
        }

        public ModifySchedulePage(ModifyScheduleViewModel msvm) : this()
        {
            Content.BindingContext = msvm;
        }
    }
}
