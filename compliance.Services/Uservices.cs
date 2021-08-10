using compliance.Database;
using compliance.Models;
using System;

namespace compliance.Services
{
    public interface IUservices
    {
        Udatabase GetUserDetails();
    }
    public class Uservices : IUservices
    {
        private readonly IUrepository _urepository;
        public Uservices(IUrepository urepository)
        {
            _urepository = urepository;
        }
        public Udatabase GetUserDetails()
        {
            return _urepository.GetUserDetails();
        }

    }
}
