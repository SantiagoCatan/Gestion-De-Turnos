using Gestion_de_turnos.Models;
using Gestion_de_turnos;
using Gestion_de_turnos.Data;
using Microsoft.EntityFrameworkCore;
using Gestion_de_turnos.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SistemaTurnosContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("SistemaTurnos")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<ProfesionalService>();
builder.Services.AddScoped<ServicesService>();
builder.Services.AddScoped<TurnoService>();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
