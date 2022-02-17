using Serilog;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.API.Services;
using VirtualWarehouse.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VirtualWarehouseDbContext>();

builder.Services.AddScoped<IAssetService, AssetService>();
builder.Services.AddScoped<ISavedImageService, SavedImageService>();


builder.Host.UseSerilog((hostBuilderContext, loggerConfiguration) => loggerConfiguration
    .WriteTo.Console()
    .WriteTo.File("\\Logs\\log-.txt", rollingInterval: RollingInterval.Day));

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