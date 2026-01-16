using Microsoft.EntityFrameworkCore;
using ApiCRUD.Concretes.Datos;
using ApiCRUD.Concretes.Servicios;
using ApiCRUD.Interfaces.Servicios;
using Newtonsoft.Json;
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
    var connection = builder.Configuration.GetConnectionString("AppDbContext");
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
builder.Services.AddScoped<IDepartament, DepartamentosServicio>();

//builder.Services.AddScoped<AppDbContext>();

var app = builder.Build();

//---------------------MIDLEWARES PERSONALIZADOS AQUI---------------------//

////redirecciona a swagger
//app.MapGet("/", (HttpContext context) =>
//{
//    //redirecciona a swagger
//    //permanent es para indicar si la redireccion es permanente o temporal
//    context.Response.Redirect("/swagger/index.html", permanent:false);
//});

//---------------------redirecciona a swagger----------------------//
//Use es para agregar un middleware al pipeline de la aplicacion
app.Use(async (context, next) => {

    //si la ruta es la raiz
    if (context.Request.Path == "/") {
        //redirecciona a swagger
        context.Response.Redirect("/swagger/index.html", permanent: false);
        return;
    }
    //si no es la raiz continua con el siguiente middleware
    await next();
});


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
