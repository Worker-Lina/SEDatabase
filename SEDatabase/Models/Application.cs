using SEDatabase.Enum;
using System;

namespace SEDatabase.Models
{
    public class Application
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Status Status { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid TechnicId { get; set; }
        public Technic Technic { get; set; }

        public int Price { get; set; }
        public DateTime Date { get; set; }

    }
}
