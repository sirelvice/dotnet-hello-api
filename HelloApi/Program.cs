var builder = WebApplication.CreateBuilder(args);

// Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger only in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Health check 
app.MapGet("/", () => Results.Ok(new { status = "ok", app = "HelloApi", framework = ".NET" }));

// Main endpoint
app.MapGet("/api/hello", () => Results.Ok(new
{
    message = "Hello from Tommy in Nairobi! 🚀 Powered by .NET 10"
}))
.WithName("HelloEndpoint");

// .WithOpenApi(); 

app.Run();
