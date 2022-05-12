using Wakanda_Mini_API.Models;
using Wakanda_Mini_API.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IAudioService, AudioService>();
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();
app.UseSwagger();

app.MapGet("/", () => "Hello World!");

app.MapPost("/create",
    (Audio audio, IAudioService service) => Create(audio, service));



app.MapGet("/get",
    (int id,  IAudioService service) => Get(id, service));

app.MapGet("/list",
    (IAudioService service) => List(service));

app.MapPut("/update",
    (Audio newAudio, IAudioService service) => Update(newAudio, service));

app.MapDelete("/delete",
    (int id, IAudioService service) => Delete(id, service));

app.Run();

app.UseSwaggerUI();


IResult Create(Audio audio, IAudioService service)
{
    var result = service.Create(audio);
    return Results.Ok(result);
}

object Get(int id, IAudioService service)
{
    throw new NotImplementedException();
}

object List(IAudioService service)
{
    throw new NotImplementedException();
}

object Update(Audio newAudio, IAudioService service)
{
    throw new NotImplementedException();
}

object Delete(int id, IAudioService service)
{
    throw new NotImplementedException();
}