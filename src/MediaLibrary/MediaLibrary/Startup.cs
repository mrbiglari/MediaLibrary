using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaLibrary.Controllers;
using MediaLibrary.Data;
using MediaLibrary.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MediaLibrary
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            SetupEntityFrameworkContext(services);

            services.AddTransient<MediaContext>();
            services.AddTransient<Repository<Media>>();

            services.AddControllers();
        }

        private void SetupEntityFrameworkContext(IServiceCollection services)
        {
            services.AddDbContext<MediaContext>(opt => opt.UseSqlServer
                            (Configuration.GetConnectionString("MediaConnection")));            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.InitializeDb();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }      
    }
}
