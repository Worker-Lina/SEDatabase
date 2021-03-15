using System;

namespace SEDatabase.Models
{
    public class Technic
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Description { get; set; }
    }
}
