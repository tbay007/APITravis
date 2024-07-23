
using Repos;
using Repos.interfaces;
using Repos.RepoInterfaces;
namespace APITravis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Adding injection into the controller
            builder.Services.AddScoped<IDogRepos, DogRepos>();
            builder.Services.AddScoped<ICatRepos, CatRepos>();
			//builder.Services.RegisterType<Animal>().PropertiesAutowired().InstancePerLifetimeScope();
			builder.Services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });

            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            

            app.MapControllers();
            
            app.Run();
        }
    }
}
