using ClubManagement.Business;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ClubManagement.ViewModel
{
    public class ScheduleListViewModel : ViewModelBase
    {
        private ObservableCollection<ScheduleViewModelBase> scheduleList;
        public ObservableCollection<ScheduleViewModelBase> ScheduleList
        {
            get => scheduleList;

            set => SetProperty(ref scheduleList, value);
        }
        public ICommand ModifyScheduleCommand { get; }

        public ScheduleListViewModel()
        {
            scheduleList = new ObservableCollection<ScheduleViewModelBase>();
            System.Linq.IQueryable<Model.Schedule> schedules = ScheduleBusiness.GetSchedules();
            foreach (Model.Schedule schedule in schedules)
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
