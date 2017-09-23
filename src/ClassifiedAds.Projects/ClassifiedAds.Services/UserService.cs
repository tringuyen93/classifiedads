using ClassifiedAds.Contracts.Entities;
using ClassifiedAds.Contracts.Services;
using ClassifiedAds.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassifiedAds.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
