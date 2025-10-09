using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

// If ASPNETCORE_URLS isn't explicitly set, prefer the platform provided port (PORT or HTTP_PORTS)
if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_URLS")))
{
    var portEnv = Environment.GetEnvironmentVariable("PORT") ?? Environment.GetEnvironmentVariable("HTTP_PORTS");
    if (!string.IsNullOrEmpty(portEnv))
    {
        var port = portEnv.Split(new[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries)[0];
        if (!string.IsNullOrWhiteSpace(port))
        {
            builder.WebHost.UseUrls($"http://+:{port}");
        }
    }
}

// Database configuration (unchanged)
var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
if (!string.IsNullOrEmpty(databaseUrl))
{
    if (databaseUrl.StartsWith("postgres://") || databaseUrl.StartsWith("postgresql://"))
    {
        var uri = new Uri(databaseUrl);
        var userInfo = uri.UserInfo.Split(':');
        var username = userInfo[0];
        var password = userInfo.Length > 1 ? userInfo[1] : string.Empty;
        var host = uri.Host;
        var port = uri.Port > 0 ? uri.Port : 5432;
        var database = uri.AbsolutePath.Trim('/');

        var additionalOptions = string.Empty;
        if (!string.IsNullOrEmpty(uri.Query))
        {
            var q = uri.Query.TrimStart('?').Split('&', StringSplitOptions.RemoveEmptyEntries);
            foreach (var kv in q)
            {
                var parts = kv.Split('=', 2);
                var key = parts[0].ToLowerInvariant();
                var value = parts.Length > 1 ? parts[1] : string.Empty;
                if (key == "sslmode")
                {
                    additionalOptions += $"Ssl Mode={value};";
                }
                else if (key == "channel_binding")
                {
                    additionalOptions += $"ChannelBinding={value};";
                }
                else
                {
                    additionalOptions += $"{key}={value};";
                }
            }
        }

        var connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password};{additionalOptions}Trust Server Certificate=true;";

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString));
    }
    else
    {
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(databaseUrl));
    }
}
else
{
    var defaultConn = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(defaultConn));
}

// Register MVC controllers and Razor Pages
builder.Services.AddControllers();
builder.Services.AddRazorPages();

// JSON options
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

// Forwarded headers for proxy scenarios
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

// Conditional HTTPS redirection (only if platform HTTPS port provided)
if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_HTTPS_PORT")))
{
    app.UseHttpsRedirection();
}

// Static files
app.UseStaticFiles();

// CORS, routing, auth
app.UseCors("AllowBlazorClient");
app.UseRouting();
app.UseAuthorization();

// Map Razor Pages and controllers
app.MapRazorPages();
app.MapControllers();

// Optionally serve a fallback page if you have one (uncomment if needed)
// app.MapFallbackToPage("/Index");

app.Run();