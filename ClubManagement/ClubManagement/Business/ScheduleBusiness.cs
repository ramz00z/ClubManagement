using ClubManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Business
{
    public static class ScheduleBusiness
    {
        private static readonly string fileName = "TestDatabase";
        public static void InsertSchedule(Schedule schedule)
        {
            DbHelper.GetInstance(fileName).Insert(schedule);
        }

        public static void UpdateSchedule(Schedule schedule)
        {
            DbHelper.GetInstance(fileName).UpdateSchedule(schedule);
        }

        public static List<Schedule> GetSchedules()
        {
            var schedules = DbHelper.GetInstance(fileName).GetSchedules();
            return schedules;
        }
    }
}
