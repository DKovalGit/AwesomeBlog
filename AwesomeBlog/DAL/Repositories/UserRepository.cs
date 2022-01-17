using Microsoft.EntityFrameworkCore;
using AwesomeBlog.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlog.DAL.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        /// <summary>
        ///  Найти комнату по имени
        /// </summary>
        public async Task<User> GetUserById(string id)
        {
            return await _context.Users.Where(r => r.Id == id).FirstOrDefaultAsync();
        }
    }
}
