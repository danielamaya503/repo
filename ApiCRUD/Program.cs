using Microsoft.EntityFrameworkCore;
using ApiCRUD.Concretes.Datos;
using ApiCRUD.Concretes.Servicios;
using ApiCRUD.Interfaces.Servicios;

//usar proyecto de ApiCRUD.Models que es biblioteca de clases


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//ayuda añadir logging
builder.Services.AddLogging();



//ayuda añadir controllers por ejemplo para API REST
builder.Services.AddControllers();

//configurar el contexto de la base de datos
builder.Services.AddDbContext<AppDbContext>(opntions =>
{
    var connection = builder.Configuration.GetConnectionString("SqlServerConnection");
    opntions.UseSqlServer(connection);
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//es para usar swagger
builder.Services.AddSwaggerGen();


//CORS es para permitir que la API sea consumida desde otros dominios
var MyAllowOrigin = "MyAllorOrigins";
builder.Services.AddCors(options => {

    options.AddPolicy(name : MyAllowOrigin, policy =>
        {
            //AllowAnyMethod es para permitir cualquier metodo (GET, POST, PUT, DELETE, etc)
            //AllowAnyHeader es para permitir cualquier cabecera
            //AllowAnyOrigin es para permitir cualquier origen
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});

//este servicio es para permitir que la API sea consumida desde otros dominios
builder.Services.AddCors();

//--------------------INYECCIONES DE DEPENDENCIAS PERSONALIZADAS AQUI--------------------//

builder.Services.AddScoped<IUsuarios, UsuariosServicio>();
//builder.Services.AddScoped<IDepartamentos, DepartamentosServicio>();


var app = builder.Build();

//---------------------MIDLEWARES PERSONALIZADOS AQUI---------------------//


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //usar CORS
    app.MapOpenApi();

    //es para usar swagger
    app.UseSwagger();
    //es para usar swagger UI es una interfaz grafica para probar la API
    app.UseSwaggerUI();
}

app.UseCors(MyAllowOrigin);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapControllers();

app.Run();
