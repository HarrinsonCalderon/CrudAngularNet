
using BTarjetas;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


//agregamos la configuracion de la bd, ya que la comentamos de dbapicontext
builder.Services.AddDbContext<TarjetasContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSQL")));
//builder.Services.AddSqlServer<TareasContext>("Server=DESKTOP-PTHQSOO\\SQLEXPRESS;database=TareasDb3;Trusted_Connection=true;Trust Server Certificate=true;Integrated Security=False;Persist Security Info=false;User ID=sa;Password=12345");

//para quitar las consultas ciclicas cuando hay consultas de 1 a n o  n a m
builder.Services.AddControllers().AddJsonOptions(opt => {
        opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
  });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
