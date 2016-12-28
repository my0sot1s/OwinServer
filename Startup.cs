using CreateDictionary.Memory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            MemoryInfor.InitMemory();
            
            var corsBuilder = new CorsPolicyBuilder();
                corsBuilder.AllowAnyHeader();
                corsBuilder.AllowAnyMethod();
                corsBuilder.AllowAnyOrigin();
                corsBuilder.AllowCredentials();

                services.AddCors(options =>
                {
                    options.AddPolicy("AllowAll", corsBuilder.Build());
                });
            services.AddMvc();
            
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(route=>{
                route.MapRoute(
                    name:"DefaultConfig",
                    template:"api/{controller=requests}/{id?}");
            });
            app.UseCors("AllowAll");
        }
        
    }
   
}