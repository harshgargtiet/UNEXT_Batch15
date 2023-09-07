using StudentDetails.Models;

namespace StudentDetails.Services.Interface
{
    public interface iUser
    {
       
        Task<User> GetUserByUsername(string username);

        Task<List<User>> AddUser(User user);

        Task<User> UpdateUser(string username, User user);

        Task<List<User>> DeleteUser(string username)

    }
}
