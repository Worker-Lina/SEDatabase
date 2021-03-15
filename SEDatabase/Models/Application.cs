using System;
using System.Collections.Generic;
using System.Text;

namespace SEDatabase.Models
{
    public class Application
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Status Status { get; set; }
        public int TechnicId { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

    }
}
