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
    public class AddScheduleViewModel : ViewModelBase
    {
        #region Fields
        private int id;
        private string texte;
        private string title;
        private string type;
        private string team;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private ScheduleListViewModel scheduleListViewModel;
        #endregion

        #region Properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                SetProperty(ref title, value);
            }
        }
        public string Texte
        {
            get
            {
                return texte;
            }
            set
            {
                SetProperty(ref texte, value);
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                SetProperty(ref type, value);
            }
        }
        public string Team
        {
            get
            {
                return team;
            }
            set
            {
                SetProperty(ref team, value);
            }
        }
        public DateTime StartDateTime
        {
            get
            {
                return startDateTime;
            }
            set
            {
                SetProperty(ref startDateTime, value);
            }
        }
        public DateTime EndDateTime
        {
            get
            {
                return endDateTime;
            }
            set
            {
                SetProperty(ref endDateTime, value);
            }
        }
        public ICommand CreateScheduleCommand { get; }
        #endregion

        #region Methods
        public AddScheduleViewModel()
        {
            CreateScheduleCommand = new Command(CreateSchedule);
        }

        public AddScheduleViewModel(ScheduleListViewModel slvm) : this()
        {
            scheduleListViewModel = slvm;
        }

        private void CreateSchedule()
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
            ScheduleBusiness.InsertSchedule(schedule);
            scheduleListViewModel.ScheduleList.Add(schedule);
        }

        private void ChangeTexte()
        {
            Texte = $"Schedule {Title} of type {Type} was created.";
        }
        #endregion
    }
}
