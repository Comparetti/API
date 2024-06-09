using Data.Context;
using Domain.Interfaces.IService;
using Microsoft.EntityFrameworkCore;
using Service.Service.Consumidor;
using Service.Service.Produtor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProdutorService, ProdutorService>();
builder.Services.AddScoped<IConsumidorService, ConsumidorService>();

if (builder.Configuration.GetValue<bool>("FeatureToggles:UseInMemoryDatabase"))
{
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseInMemoryDatabase("DatabaseName"));
}
else
{
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
}

var app = builder.Build();

// Configuração para migrações, se não estiver usando banco de dados em memória
if (!builder.Configuration.GetValue<bool>("FeatureToggles:UseInMemoryDatabase"))
{
    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        dbContext.Database.Migrate();
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
