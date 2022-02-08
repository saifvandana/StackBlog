using StackBlog.Data.Models;
using System.Threading.Tasks;

namespace StackBlog.Service.Interfaces
{
	public interface IUserService
    {
        ApplicationUser Get(string id);
        Task<ApplicationUser> Update(ApplicationUser applicationUser);
    }
}