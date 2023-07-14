using Microsoft.EntityFrameworkCore;
using Discoteque.Data;
using Discoteque.Business.Services;
using Discoteque.Business.IServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DiscotequeContext>(
    opt => opt.UseInMemoryDatabase("Discoteque")
);
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IArtistsService, ArtistsService>();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IArtistsService, ArtistsService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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

using (var scope = app.Services.CreateScope())
{
    var artistService = scope.ServiceProvider.GetRequiredService<IArtistsService>();
    
    await artistService.CreateArtist(new Discoteque.Data.Models.Artist{
        Name = "Karol G",
        Label = "Universal",
        IsOnTour = true
    });

    await artistService.CreateArtist(new Discoteque.Data.Models.Artist{
        Name = "Juanes",
        Label = "SONY BMG",
        IsOnTour = true
    });
}