using System;
using System.Collections.Generic;
using System.Text;

namespace SEDatabase.Models
{
    public abstract class User 
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public string Photo { get; set; }

        
        
    }
}
