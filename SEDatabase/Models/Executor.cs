using System;
using System.Collections.Generic;
using System.Text;

namespace SEDatabase.Models
{
    public class Executor : User
    {
        public int Price { get; set; }
        //public ICollection<Task> Tasks { get; set; }
        public Guid TechnicId { get; set; }
    }
}
