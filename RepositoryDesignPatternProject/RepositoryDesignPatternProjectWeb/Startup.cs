using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using RepositoryDesignPatternProjectWeb.Data.Context;
using RepositoryDesignPatternProjectWeb.Data.Interfaces;
using RepositoryDesignPatternProjectWeb.Data.Repositories;
using RepositoryDesignPatternProjectWeb.Data.UnitOfWork;
using RepositoryDesignPatternProjectWeb.Mapping;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDesignPatternProjectWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BankContext>(opt =>
            {
                opt.UseSqlServer("Server=DESKTOP-6NFJQ9U;Database=BankDb;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
            });
            //services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            //services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            //services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUow, Uow>();
            services.AddScoped<IUserMapper,UserMapper>();
            services.AddScoped<IAccountMapper, AccountMapper>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //open wwwroot
            app.UseStaticFiles();

            //open nodemodules
            app.UseStaticFiles(
            new StaticFileOptions{
            FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory
            (),"node_modules")),
            RequestPath="/node_modules"
            });


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}