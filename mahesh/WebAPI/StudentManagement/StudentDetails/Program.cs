using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;
using StudentDetails.Services.ServiceClasses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentManagementContext>(
    optionsAction: options => options.UseNpgsql(
        builder.Configuration.GetConnectionString(
            "PostGreSQLConnectionString"
            )
        )
    );

builder.Services.AddDbContext<UserContext>(
    optionsAction: options => options.UseNpgsql(
        builder.Configuration.GetConnectionString(
            "PostGreSQLConnectionString"
            )
        )
    );

builder.Services.AddScoped<IStudent, StudentService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
