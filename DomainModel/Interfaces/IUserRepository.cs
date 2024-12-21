﻿using DomainModel.Entities;

namespace DomainModel.Interfaces
    {
    public interface IUserRepository
        {
        User GetById(int id);
        IEnumerable<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Delete(int id);
        }
    }