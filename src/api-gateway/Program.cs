var builder = WebApplication.CreateBuilder(args);
builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();
app.MapGet("/", () => "Hello From Gateway");
app.UseStaticFiles(); // The middleware runs before routing happens => no route was found

app.UseRouting();
app.MapReverseProxy();
app.Run();
