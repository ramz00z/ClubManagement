using System.Linq;
using System.Collections.ObjectModel;
using ClubManagement.Model;
using System.Windows.Input;
using Xamarin.Forms;
using ClubManagement.Business;

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
            var schedules = ScheduleBusiness.GetSchedules();
            foreach (var schedule in schedules)
            {
                scheduleList.Add(schedule);
            }
        }
    }
}
