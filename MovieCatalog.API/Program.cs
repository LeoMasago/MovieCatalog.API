using MovieCatalog.API.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<AppDbContext>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    //Swagger
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint(
        "/openapi/v1.json",
        "MovieCatalog API"
        );
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
