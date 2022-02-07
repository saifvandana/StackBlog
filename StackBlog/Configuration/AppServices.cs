using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackBlog.Data;
using StackBlog.Data.Models;

namespace StackBlog.Configuration
{
	public static class AppServices
	{
		public static void AddDefaultServices(this IServiceCollection serviceCollection, IConfiguration configuration) {
			serviceCollection.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					configuration.GetConnectionString("DefaultConnection")));
			serviceCollection.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<ApplicationDbContext>();
			serviceCollection.AddControllersWithViews().AddRazorRuntimeCompilation();
			serviceCollection.AddRazorPages();
		}
	}
}
