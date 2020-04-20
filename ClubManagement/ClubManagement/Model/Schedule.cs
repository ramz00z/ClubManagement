using SQLite;
using System;

namespace ClubManagement.Model
{
    public class Schedule
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Team { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Id = {Id} Title = {Title} Team = {Team} StartDateTime = {StartDateTime} EndDateTime = {EndDateTime} Type = {Type}";
        }
    }
}
