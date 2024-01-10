using AfsarZMiniChallenge5to7.Services.ChallengeFive;
using AfsarZMiniChallenge5to7.Services.ChallengeSeven;
using AfsarZMiniChallenge5to7.Services.ChallengeSix;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IChallengeFiveService, ChallengeFiveService>();
builder.Services.AddScoped<IChallengeSixService, ChallengeSixService>();
builder.Services.AddScoped<IChallengeSevenStringService, ChallengeSevenService>();

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
