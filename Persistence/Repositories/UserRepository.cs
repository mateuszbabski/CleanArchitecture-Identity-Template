using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> RegisterNewUserAsync(User user)
        {
            //var newUser = new User()
            //{
            //    FirstName = user.FirstName,
            //    LastName = user.LastName,
            //    PhoneNumber = user.PhoneNumber,
            //    Email = user.Email,
            //    Password = user.Password,
            //    Role = Roles.Basic.ToString()
            //};

            //var hashedPassword = _passwordHasher.HashPassword(newUser, user.Password);
            //newUser.PasswordHash = hashedPassword;

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task UpdateUserAsync(User user)
        {
            await _dbContext.SaveChangesAsync();
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}

        

