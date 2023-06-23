using MedUnify.WebApi.Data;
using MedUnify.WebApi.Services;
using MedUnify.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

namespace MedUnify.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContextPool<MedUnifyDbContext>(x => x.UseSqlite(@"Data Source=.\Data\Db\medunify.db"));
        builder.Services.AddScoped<IPatientService, PatientService>();
        builder.Services.AddScoped<IPatientVisitService, PatientVisitService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IOrganisationService, OrganisationService>();

        
        builder.Services.AddControllers().AddJsonOptions(op =>
        {
            op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            op.JsonSerializerOptions.MaxDepth = 32;
        });

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("MyCorsPolicy",
                builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
        });

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();
        using var serviceScope = ((IApplicationBuilder)app).ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
        var context = serviceScope.ServiceProvider.GetService<MedUnifyDbContext>();
        context?.Database.Migrate();
        context?.SeedInitialData();
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        app.UseCors("MyCorsPolicy");

        app.MapControllers();

        app.Run();
    }
}