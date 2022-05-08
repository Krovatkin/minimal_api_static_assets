var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.UseStaticFiles();

app.MapGet("/", (IWebHostEnvironment _env) => 

// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-6.0
// ~ doesn't always work try both ~/images and ~/
Results.Text($"<img src='/images/download.jpg'>{_env.WebRootPath} Hello World {_env.ContentRootPath}!", "text/html"));

app.Run();
