using SEDatabase.Enum;
using System;

namespace SEDatabase.Models
{
    public class Application
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Status Status { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid TechnicId { get; set; }
        public Technic Technic { get; set; }

        public int Price { get; set; }
        public DateTime Date { get; set; }

    }
}
