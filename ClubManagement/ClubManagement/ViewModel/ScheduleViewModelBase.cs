using System;

namespace ClubManagement.ViewModel
{
    public class ScheduleViewModelBase : ViewModelBase
    {
        #region Fields
        protected int id;
        protected string title;
        protected string type;
        protected string team;
        protected DateTime startDateTime;
        protected DateTime endDateTime;
        #endregion

        #region Properties
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
        public string Type
        {
            get => type;
            set => SetProperty(ref type, value);
        }
        public string Team
        {
            get => team;
            set => SetProperty(ref team, value);
        }
        public DateTime StartDateTime
        {
            get => startDateTime;
            set => SetProperty(ref startDateTime, value);
        }
        public DateTime EndDateTime
        {
            get => endDateTime;
            set => SetProperty(ref endDateTime, value);
        }
        #endregion
    }
}
