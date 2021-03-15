using System;
using System.Collections.Generic;
using System.Text;

namespace SEDatabase.Models
{
    public class Notification 
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
    }
}
