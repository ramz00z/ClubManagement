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
    public class ModifyScheduleViewModel : ScheduleViewModelBase
    {
        public ICommand ModifyScheduleCommand { get; }
       
        #region Methods
        public ModifyScheduleViewModel()
        {
            ModifyScheduleCommand = new Command(UpdateSchedule);
        }

        //public ModifyScheduleViewModel(Schedule schedule) : this()
        //{
        //    id = schedule.Id;
        //    title = schedule.Title;
        //    team = schedule.Team;
        //    startDateTime = schedule.StartDateTime;
        //    endDateTime = schedule.EndDateTime;
        //}

        private void UpdateSchedule()
        {
            var schedule = new Schedule
            {
                Id = id,
                Title = Title,
                Team = Team,
                Type = Type,
                EndDateTime = EndDateTime,
                StartDateTime = StartDateTime
            };
            ScheduleBusiness.UpdateSchedule(schedule);
        }
        #endregion
    }
}
