using ClubManagement.Model;
using System.Collections.Generic;
using System.Linq;

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

        public static IQueryable<Schedule> GetSchedules()
        {
            var schedules = DbHelper.GetInstance(fileName).GetSchedules();
            return schedules;
        }
    }
}
