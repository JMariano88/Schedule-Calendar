using Microsoft.EntityFrameworkCore;
using YourAppNamespace.Data; // For AppDbContext
using Microsoft.OpenApi.Models; // For Swagger

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add your DbContext and other services
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add support for controllers
builder.Services.AddControllers();

// Add Swagger for API documentation (optional, useful for testing API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "YourApp API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "YourApp API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();  // Ensures controllers are mapped to routes

app.Run();

