using ConsoleToDB.Data;
using Microsoft.EntityFrameworkCore;
using Repositary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(optionsAction: options =>
          options.UseSqlServer(builder.Configuration.GetConnectionString("connectDB")));
builder.Services.AddControllers();
builder.Services.AddScoped<IStudentDetailsServices, StudentDetailsRepositary>();
builder.Services.AddScoped<IDisplayServices, DisplayRepositary>();
builder.Services.AddScoped<IMarkServices, MarkDetailsRepositary>();

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
