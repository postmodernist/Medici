using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageAlbum.Application;
using ImageAlbum.Application.MappingProfile;
using ImageAlbum.Infrastructure.Interfaces;
using ImageAlbum.Infrastructure.MongoDbConfig;
using ImageAlbum.Infrastructure.Repositories;
using ImageAlbum.Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace ImageAlbum.API
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ImageAlbum.API", Version = "v1" });
            });

            services.AddTransient<IImageAlbumRepository, ImageAlbumRepository>();
            services.AddTransient<IImageAlbumService, ImageAlbumService>();

            services.Configure<MongoDbConfig>(Configuration.GetSection(nameof(MongoDbConfig)));
            services.AddSingleton<IMongoDbConfig>(sp => sp.GetRequiredService<IOptions<MongoDbConfig>>().Value);
            

            services.AddAutoMapper(typeof(MappingProfile));
            services.AddApplicationServices();

            
        }

        // This method gets called by the runtim
        // e. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ImageAlbum.API v1"));
            }

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
