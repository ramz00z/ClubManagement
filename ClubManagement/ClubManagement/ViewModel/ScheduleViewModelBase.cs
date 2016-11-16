using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            get { return id; }
            set { SetProperty(ref id, value); }
        }
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
        #endregion
    }
}
