﻿using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IUserService
    {
        void AddAdmin(int id, string updatedBy);
        void ChangeAdminStatus(int id, bool originalStatus, string updatedBy);
        List<UsersModel> GetAllUsers();
        Boolean isPasswordSame(int id, string password);
        void updateUserPassword(int id, string password,string updatedBy);
    }
}