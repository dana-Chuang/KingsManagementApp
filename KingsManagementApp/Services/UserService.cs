﻿using DataLayer.Interfaces;
using DataLayer.Models;

namespace KingsManagementApp.Controllers
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository _usersRepository;

        public UserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public List<UsersModel> GetAllUsers()
        {
            return _usersRepository.GetAll();
        }

        public Boolean isPasswordSame(int id, string password)
        {
            var oldPassword = _usersRepository.getPasswordBy(id);
            return oldPassword.ToString() == password;
        }

        public void updateUserPassword(int id, string newpassword, string updatedBy)
        {
            _usersRepository.updatePassword(id,newpassword,updatedBy);
        }
    }
}