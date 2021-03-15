using System;

namespace SEDatabase.Models
{
    public class Notification 
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
