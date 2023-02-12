using API_Valorant_NET.Data;
using API_Valorant_NET.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//obtenemos la string de coneccion accediendo al builder y usando el metodo GetConnection String pasandole como valor el nombre que le asignamos
var connectionString = builder.Configuration.GetConnectionString("PostgreSQLConnection");
//luego, en los servicios del builder, agrego el contexto de la base de datos (la representacion),y le paso options que dicen que: el programa usara Npgsql (dependencia previamente instalada), recibiendo como parametro la URL de conexion que sacamos antes
builder.Services.AddDbContext<ValorantDB>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/agents/", async (Agents agent, ValorantDB db) =>
{
    db.Agents.Add(agent);
    await db.SaveChangesAsync();

    return Results.Created($"/agents/{agent.ID}", agent);
});


app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}