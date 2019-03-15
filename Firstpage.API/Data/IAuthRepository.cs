using System.Threading.Tasks;
using Firstpage.API.Models;

namespace Firstpage.API.Data
{
    public interface IAuthRepository
    {
            /*the given task is the method calling where <User> is the return type and we pass values 
            to the register function of the repository.*/
         Task<User> Register(User user,string password);
         Task<User> Login(string username,string password);

         Task<bool> UserExists(string username); 
    }
}