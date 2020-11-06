using System;

namespace Domain.Users
{
    public class User
    {
        public Profile Profile { get; set; }

        public string Name { get; set; }

        public Guid Id { get; set; }

        public User( string name, Profile profile)
        {
            Id = Guid.NewGuid();
            Profile = profile;
            Name = name;
        }
    }
}