using Cars.CrossCutting.Configuration;
using Cars.DataAccess.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IoC.Register(builder.Services);

//Configuracion de la migración a BBDD
string myconnection = "server = localhost; port = 3306; database = cursonet; user = root; password = root; Persist Security Info = False; Connect Timeout = 300";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMySql(
myconnection, ServerVersion.AutoDetect(myconnection),
b => b.MigrationsAssembly("Cars.DataAccess.Services")
)
);

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


