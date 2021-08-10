using Microsoft.Graph;
using System;
using compliance.Database;

namespace compliance.Models
{
    public interface IUrepository
    {
        Udatabase GetUserDetails();
    }
    public class Urepository : IUrepository
    {       
        public Udatabase GetUserDetails()
        {
            Udatabase user = new Udatabase();
            user.ID = 1;
            user.Name = "manish";
            user.Age = 12;
            return user;

        }

       
    }       
}
