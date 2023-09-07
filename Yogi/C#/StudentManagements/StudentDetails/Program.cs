using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interface;
using StudentDetails.Services;
using StudentDetails.Services.Service_Classes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentManagementContext>(
       optionsAction: options =>options.UseNpgsql(
           builder.Configuration.GetConnectionString(
               "PostGreSQLConnString")  )
    );

builder.Services.AddDbContext<UserContext>(
    optionsAction: options => options.UseNpgsql(
           builder.Configuration.GetConnectionString(
               "PostGreSQLConnString")));

builder.Services.AddScoped<iStudent, StudentService>();
builder.Services.AddScoped<iUser, UserService>();
builder.Services.AddScoped<iToken, TokenService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();


