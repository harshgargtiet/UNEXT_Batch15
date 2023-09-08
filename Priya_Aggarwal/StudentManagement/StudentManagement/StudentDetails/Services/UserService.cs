using Microsoft.EntityFrameworkCore;
using StudentDetails.GlobalExceptions;
using StudentDetails.Models;
using StudentDetails.Services.Interface;

namespace StudentDetails.Services
{
    public class UserService : IUser
    {
        private UserContext _context;

        public UserService(UserContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> DeleteUser(string username)
        {
            var ruser = await _context.Users.FindAsync(username);

            if (ruser != null)
            {
                _context.Users.Remove(ruser);
                _context.SaveChanges();
                return await _context.Users.ToListAsync();
            }
            else
            {
                throw new Exception(ExceptionDetails.exceptionMessages[1]);
            }
        }

        public async Task<User> GetUserByUsername(string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception(ExceptionDetails.exceptionMessages[1]);
            }
        }

        public async Task<User> UpdateUser(string username, User user)
        {
            var ruser = await _context.Users.FindAsync(username);

            if (ruser != null)
            {
                ruser.Password = user.Password;
                ruser.Role = user.Role;

                _context.SaveChanges();
                return await _context.Users.FindAsync(username);
            }
            else
            {
                throw new Exception(ExceptionDetails.exceptionMessages[1]);
            }
        }
    }
}
