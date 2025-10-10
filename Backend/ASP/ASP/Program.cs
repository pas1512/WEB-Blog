var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Отримуємо порт з середовища або ставимо 8080
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";

// Додаємо URL, на якому слухаємо
app.Urls.Add($"http://0.0.0.0:{port}");

app.Run();
