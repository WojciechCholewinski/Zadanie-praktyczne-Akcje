using Kurs_Udemy_2;

var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddControllers();
builder.Services.AddTransient<IWeatherForecastService, WeatherForecastService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
