

using System.Threading.Tasks;

namespace NetCoreAngular_Project.Data{
    public interface IAuthRepository{
        Task<User> Register(User user,string password);
        Task<User> Login(string userName,string password);
        Task<bool> UserExists(string userName);
    }
}