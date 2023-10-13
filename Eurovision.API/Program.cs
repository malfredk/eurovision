using Microsoft.EntityFrameworkCore;
using Eurovision.API.Repository.Contract;
using Eurovision.API.Repository;
using Eurovision.Entity.DataAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PlayerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PlayerDbContext") ?? throw new InvalidOperationException("Connection string 'EurovisionDbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
