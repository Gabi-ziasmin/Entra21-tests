using System;

namespace Domain.Users
{
    public class User
    {
        public Profile Profile { get; set; }

        public string Name { get; set; }

        public Guid Id { get; set; } = Guid.NewGuid();  

        public User( string name, Profile profile)
        {
            Profile = profile;
            Name = name;
        }
    }
}