using BackTarjeta.AplicationDbContext;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



//agregamos la configuracion de la bd, ya que la comentamos de dbapicontext
builder.Services.AddDbContext<AplicationDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSQL")));

//para quitar las consultas ciclicas cuando hay consultas de 1 a n o  n a m
builder.Services.AddControllers().AddJsonOptions(opt => {
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
