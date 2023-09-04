using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interface;
using StudentDetails.Services.ServiceClasses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentMgmtContext>(
    optionsAction: options => options.UseNpgsql(
        builder.Configuration.GetConnectionString(
            "PostgreSQLConnectionString")
        )
);

builder.Services.AddScoped<IStudent, StudentService>();
// put all the configurations details before building app
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
