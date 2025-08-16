using RPSLSGame.Interfaces;
using RPSLSGame.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IChoiceService, ChoiceService>();
builder.Services.AddSingleton<IGameService, GameService>();
builder.Services.AddHttpClient<IRandomNumberService, RandomNumberService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
