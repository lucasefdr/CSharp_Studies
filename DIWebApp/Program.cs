using DIWebApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();


// Injecting dependencies
builder.Services.AddScoped<IMessenger, Messenger>();

// Add services to the container.
var app = builder.Build();

app.MapGet("/DI", (IMessenger messenger) => messenger.SendMessage("Hello, World! Training DI in web apps."));

app.MapControllers();
app.Run();
