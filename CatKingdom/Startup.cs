using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using CatKingdom.Models;

namespace CatKingdom
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
        //   .AddEntityFrameworkStores<CatKingdomContext>()
      services.AddDbContext<CatKingdomContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      services.AddControllers();
      services.AddSwaggerGen(swagger =>
     {
       //This is to generate the Default UI of Swagger Documentation    
       swagger.SwaggerDoc("v1", new OpenApiInfo
       {
         Version = "v1",
         Title = "ASP.NET 5 Web API",
         Description = "Authentication and Authorization in ASP.NET 5 with JWT and Swagger"
       });
     });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseSwagger();
      app.UseSwaggerUI(c =>
                {
                  c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                });
    //   app.UseHttpsRedirection();
      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

    }
  }
}
