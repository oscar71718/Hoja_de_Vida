using static System.Net.Mime.MediaTypeNames;


//Constructor de la p�gina
var builder = WebApplication.CreateBuilder(args);

//Arranque de servicios de vistas
builder.Services.AddControllersWithViews();

//Construye la p�gina
var app = builder.Build();

//Uso de archivos est�ticos y mapeo de controladores
app.UseStaticFiles();
app.MapControllers();

//Arranque de p�gina
app.Run();