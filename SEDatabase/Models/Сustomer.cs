using System;
using System.Collections.Generic;
using System.Text;

namespace SEDatabase.Models
{
    public class Сustomer : User
    {
        //public ICollection<Application> Applications { get; set; }
        public Guid ApplicationId { get; set; }
    }
}
