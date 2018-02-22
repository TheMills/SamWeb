using System;
using System.Collections.Generic;

namespace SamWeb.API.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User LogStarter { get; set; }
        public User LogEnder { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? ClosedDate { get; set; }
        public List<LogLine> LogLines { get; set; }
    }
}