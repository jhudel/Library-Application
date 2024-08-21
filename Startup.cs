using TechExam.Data;
using TechExam.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Microsoft.OpenApi.Models;
using TechExam.Interfaces;

namespace TechExam
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Tech Exam Swagger APIs",
                    Version = "v1",
                    Description = "Api collection for the application",
                });
            });

            services.AddControllers();

            services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
            });

            services.AddCors();

            services.AddScoped<LoginInterface, LoginService>();
            services.AddScoped<BookInterface, BookService>();

            //var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=FirstDB;Trusted_Connection=True;";
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(connectionString));

            // Add the database context with the connection string
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            Console.WriteLine($"Connection String: {connectionString}");


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tech Exam Swagger APIs");
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Use CORS middleware
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    name: "updateBook",
                    pattern: "api/text/updateBook/{id}",
                    defaults: new { controller = "book", action = "updateBook" }
                );
            });
        }
    }
}
