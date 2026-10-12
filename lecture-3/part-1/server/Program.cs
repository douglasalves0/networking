var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/sum", (int A, int B) => {
    return Results.Json(
        new { C = A + B },
        statusCode: 200
    );
});

app.Run("http://localhost:8080");