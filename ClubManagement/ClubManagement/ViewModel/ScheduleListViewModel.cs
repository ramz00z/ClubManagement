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
        private ObservableCollection<ScheduleViewModelBase> scheduleList;
        public ObservableCollection<ScheduleViewModelBase> ScheduleList
        {
            get { return scheduleList; }

            set { SetProperty(ref scheduleList, value); }
        }

        public ScheduleListViewModel()
        {
            scheduleList = new ObservableCollection<ScheduleViewModelBase>();
            var schedules = ScheduleBusiness.GetSchedules();
            foreach (var schedule in schedules)
            {
                var s = new ScheduleViewModelBase
                {
                    Id = schedule.Id,
                    Title = schedule.Title,
                    Team = schedule.Team,
                    Type = schedule.Type,
                    StartDateTime = schedule.StartDateTime,
                    EndDateTime = schedule.EndDateTime
                };
                scheduleList.Add(s);
            }
        }
    }
}
