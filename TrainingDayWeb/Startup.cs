using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ManagerContracts;
using Application.ManagerImplementations;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using EntityFramework;
using EntityFramework.Repositories.Contracts;
using EntityFramework.Repositories.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TrainingDayWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDataContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper();
            services.AddMvc().AddJsonOptions(
            options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddAutofac();


            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<DefaultModule>();
            containerBuilder.Populate(services);
            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Training}/{action=Index}/{id?}");
            });
        }
    }
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //builder.RegisterAssemblyTypes(assembly)
            //       .Where(t => t.Name.EndsWith("Repository"))
            //       .AsImplementedInterfaces();


            builder.RegisterType<TrainingRepository>().As<ITrainingRepository>();
            builder.RegisterType<ExerciseRepository>().As<IExerciseRepository>();
            builder.RegisterType<SetRepository>().As<ISetRepository>();

            builder.RegisterType<TrainingManager>().As<ITrainingManager>();
            builder.RegisterType<SetManager>().As<ISetManager>();
            builder.RegisterType<ExerciseManager>().As<IExerciseManager>();
        }
    }

}
