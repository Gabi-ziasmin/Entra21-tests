using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.Users
{
    static class UsersRepository
    {
       private static List<User> _users = new List<User>();
       public static IReadOnlyCollection<User> Users => _users;

       public static void Add(User user)
       {
           _users.Add(user);
       }
    }
}