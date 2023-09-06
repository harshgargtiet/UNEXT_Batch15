using Student_Management.Models;

namespace Student_Management.Services.Interface
{
    public interface IUser
    {
        Task<User> GetUserByUsername(string username);

        Task<List<User>> AddUser(User user);

        Task<User> UpdateUser(string username, User user);

        Task<List<User>> DeleteUser(string username);
    }
}
