using AwesomeBlog.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlog.DAL.Repositories
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа User в базе 
    /// </summary>
    public interface IUserRepository
    {
        //Task AddUser(User user);
        Task<User> GetUserById(string id);
        //Task UpdateRoom(User user, UpdateUserQuery query);
    }
}
