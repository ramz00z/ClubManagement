using ClubManagement.Business;
using ClubManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClubManagement.ViewModel
{
    public class AddScheduleViewModel : ScheduleViewModelBase
    {
        public ICommand CreateScheduleCommand { get; }
        protected ScheduleListViewModel scheduleListViewModel;

        #region Methods
        public AddScheduleViewModel()
        {
            CreateScheduleCommand = new Command(CreateSchedule);
            startDateTime = DateTime.Now;
            endDateTime = DateTime.Now;
        }

        public AddScheduleViewModel(ScheduleListViewModel slvm) : this()
        {
            scheduleListViewModel = slvm;
        }

        private void CreateSchedule()
        {
            var schedule = new Schedule
            {
                Title = Title,
                Team = Team,
                Type = Type,
                EndDateTime = EndDateTime,
                StartDateTime = StartDateTime
            };
            ScheduleBusiness.InsertSchedule(schedule);
            ScheduleViewModelBase svmb = ObjectMapper.Map<Schedule, ScheduleViewModelBase>(schedule);
            scheduleListViewModel.ScheduleList.Add(svmb);
        }
        #endregion
    }
}
