var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    var todo = new Todo(Guid.NewGuid(), "Ir a academia", false);
    return Results.Ok();
});

app.Run();
