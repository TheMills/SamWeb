using System;

namespace SamWeb.API.Models
{
    public class LogLine
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Text { get; set; }
        public User Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Journal Journal { get; set; }
    }
}