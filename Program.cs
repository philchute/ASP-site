using Microsoft.EntityFrameworkCore;
using ASP_site.Data;
using ASP_site.Helpers;
using ASP_site.Services;
using ASP_site.Models;
using QuestPDF.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Set QuestPDF License
QuestPDF.Settings.License = LicenseType.Community;

// Configure Kestrel to listen only on localhost for port 5175
builder.WebHost.UseUrls("http://localhost:5175"); 

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

// Configure MasterServerSettings using the options pattern
builder.Services.Configure<MasterServerSettings>(settings => {
    builder.Configuration.GetSection("MasterServers").Bind(settings.Servers);
});

// Register Game Data Service (Singleton as it holds loaded data)
builder.Services.AddSingleton<IGameDataService, GameDataService>();

// Register Server Blacklist Service (Singleton as it caches the blacklist)
builder.Services.AddSingleton<IServerBlacklistService, ServerBlacklistService>();

// Register Application Services
// Add HttpClient for ServerBrowserService and ServerBlacklistService
builder.Services.AddHttpClient();
builder.Services.AddSingleton<ThreeNetworksQuery>();

builder.Services.AddMemoryCache();

// Register application services
builder.Services.AddSingleton<ServerBrowserService>();
builder.Services.AddSingleton<SiteMapService>();
builder.Services.AddSingleton<BlogService>();
builder.Services.AddSingleton<ScaleConverterService>();

// Register Background Worker
builder.Services.AddHostedService<GameServerWorker>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Add 404 Error Handling
app.UseStatusCodePagesWithReExecute("/NotFound");

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();
app.MapRazorPages();

// Initialize the database FIRST
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<GameContext>();
    context.Database.EnsureCreated();
    DbInitializer.Initialize(context); // Data is seeded here
}

// THEN Initialize Game Data Service (which reads from the DB)
using (var scope = app.Services.CreateScope())
{
    var gameDataService = scope.ServiceProvider.GetRequiredService<IGameDataService>();
    await gameDataService.InitializeAsync(); // Now it should find the data
}

app.Run();