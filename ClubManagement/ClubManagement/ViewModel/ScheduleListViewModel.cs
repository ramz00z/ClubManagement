using System.Linq;
using System.Collections.ObjectModel;
using ClubManagement.Model;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClubManagement.ViewModel
{
    public class ScheduleListViewModel : ViewModelBase
    {
        private ObservableCollection<Schedule> scheduleList;
        public ObservableCollection<Schedule> ScheduleList
        {
            get { return scheduleList; }

            set { SetProperty(ref scheduleList, value); }
        }

        public ScheduleListViewModel()
        {
            scheduleList = new ObservableCollection<Schedule>();
        }
    }
}
