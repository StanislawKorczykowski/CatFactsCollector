using CatFactsCollector.Contracts;
using CatFactsCollector.Services;

namespace CatFactsCollector;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();
        builder.Services.AddControllers();
        builder.Services.AddScoped<ICatFactService, CatFactService>();
        builder.Services.AddScoped<IFileService, FileService>();
        builder.Services.AddHttpClient();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var config = builder.Configuration;
        if (!config.GetSection("FilePath").Exists() || !config.GetSection("BaseUrl").Exists())
            throw new Exception("Section FilePath and BaseUrl are required");
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapControllers();
        app.UseHttpsRedirection();
        
        app.UseAuthorization();
        

        app.Run();
    }
}