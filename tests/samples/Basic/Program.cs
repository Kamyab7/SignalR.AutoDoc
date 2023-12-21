using Basic;
using SignalR.AutoDoc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAutoDocUI();

app.MapHub<SampleHub>("/sample-hub");

app.Run();