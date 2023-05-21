using eVoucher_BUS.Services;
using eVoucher_DAL;
using eVoucher_DAL.Repositories;
using eVoucher_DTO.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace eVoucherDatabaseWebService
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI();
            /*
                * code to customize Swagger
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eVoucherDatabaseWebService v1");
            });
            */
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<eVoucherDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    x => x.MigrationsAssembly("eVoucher_Migrations")));
            
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<eVoucherDbContext>()
                .AddDefaultTokenProviders();
            //Declare DI 
            services.AddScoped<GameRepository>();
            services.AddScoped<GameService>();
            services.AddScoped<StaffRepository>();
            services.AddScoped<StaffService>();
            services.AddScoped<PartnerRepository>();
            services.AddScoped<PartnerService>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            /*
             * code to customize Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eVoucherDatabaseWebService", Version = "v1" });
            });
            */
        }
    }
}