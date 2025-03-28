using ASP_site.Data;

namespace Games
{
  public class Program
  {
    public static void Main(string[] args)
    {
    var host = CreateHostBuilder(args).Build();
    CreateDbIfNotExists(host);
    host.Run();
    }

    // call the initializer to populate the database
    private static void CreateDbIfNotExists(IHost host)
    {
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<GameContext>();
    context.Database.EnsureCreated();
    DbInitializer.Initialize(context);
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
          webBuilder.UseStartup<Startup>();
        });
  }
}
