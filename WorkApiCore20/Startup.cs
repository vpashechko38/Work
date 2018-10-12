using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WorkApiCore20.Models;

namespace WorkApiCore20
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
            //var connection = $"Server=localhost;User Id=postgres;Port=5432;Database=TestDB";
            //services.AddDbContext<DataContext>(opt => opt.UseNpgsql(connection));
            var connection = $"Server=(localdb)\\mssqllocaldb;Database=sdbd;Trusted_Connection=True;";
            //var connection = $"server=94.250.254.161;database=memorial;user=m3ddev;password=0C5I0L5j;persistsecurityinfo=True;SslMode=none";
            services.AddDbContext<DataContext>(opt => opt.UseSqlServer(connection));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //using (var scope = scopeFactory.CreateScope())
            //{
            //    var context = scope.ServiceProvider.GetService<DataContext>();
            //    context.Database.Migrate();
            //}
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
        }
    }
}
