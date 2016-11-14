using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Model
{
    public class Schedule
    {
        public string Title { get; set; }
        public string Team { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Type { get; set; }
    }
}
