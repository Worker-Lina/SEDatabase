using System;


namespace SEDatabase.Models
{
    public abstract class SystemUser 
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
