using static System.Net.Mime.MediaTypeNames;


//Constructor de la página
var builder = WebApplication.CreateBuilder(args);

//Arranque de servicios de vistas
builder.Services.AddControllersWithViews();

//Construye la página
var app = builder.Build();

//Uso de archivos estáticos y mapeo de controladores
app.UseStaticFiles();
app.MapControllers();

//Arranque de página
app.Run();