using BackEnd.Pages.Models;
using Microsoft.AspNetCore.Builder;
using System.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace BackEnd
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationUser>(options => options.UseSqlServer(Configuration.GetConnectionString("Myconnection")));
            services.AddControllersWithViews();
        }
    }
}
