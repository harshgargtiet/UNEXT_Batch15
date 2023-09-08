using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services;
using StudentDetails.Services.Interface;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentMgmtContext>(
    optionsAction: options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostGreSQLConnString")));

builder.Services.AddDbContext<UserContext>(
    optionsAction: options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostGreSQLConnString")));

builder.Services.AddScoped<IStudent, StudentService>();
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IToken, TokenService>();

//acope type services 
builder.Services.AddScoped<IStudent,StudentService>();

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
