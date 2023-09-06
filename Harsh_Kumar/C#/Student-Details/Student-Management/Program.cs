using Microsoft.EntityFrameworkCore;
using Student_Management.Models;
using Student_Management.Services;
using Student_Management.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentManagementContext>(
    optionsAction: options => options.UseNpgsql(
        builder.Configuration.GetConnectionString(
            "PostGreSQLConnString")));

builder.Services.AddDbContext<UserContext>(
    optionsAction: options => options.UseNpgsql(
        builder.Configuration.GetConnectionString(
            "PostGreSQLConnString")));

builder.Services.AddScoped<iStudent, StudentService>();
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IToken, TokenService>();

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
