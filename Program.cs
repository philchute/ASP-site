using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using ASP_site.Data;
using ASP_site.Data.Initializers;
using ASP_site.Helpers;
using ASP_site.GameServerListCommon.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add in-memory database
builder.Services.AddDbContext<GameContext>(options =>
    options.UseInMemoryDatabase("GameDb"));

// Add session support
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Register Game Data Service (Singleton as it holds loaded data)
builder.Services.AddSingleton<IGameDataService, GameDataService>();

// Register Application Services
// Add HttpClient for SteamServerBrowserApiService
builder.Services.AddHttpClient(); // Registers IHttpClientFactory
builder.Services.AddMemoryCache(); // Registers IMemoryCache

// Services making external calls are often Scoped or Transient
builder.Services.AddScoped<SteamServerBrowserApiService>();

// Register Background Worker
builder.Services.AddHostedService<GameServerWorker>();

var app = builder.Build();

// Initialize Game Data Service after building the app
using (var scope = app.Services.CreateScope())
{
    var gameDataService = scope.ServiceProvider.GetRequiredService<IGameDataService>();
    await gameDataService.InitializeAsync();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();
app.MapRazorPages();

// Initialize the database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<GameContext>();
    context.Database.EnsureCreated();
    DbInitializer.Initialize(context);
}

app.Run();