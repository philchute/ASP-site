using Microsoft.EntityFrameworkCore;
using ASP_site.Data;

namespace Games
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      // configure session state cookie handler
      services.AddDistributedMemoryCache();

      services.AddSession(options =>
      {
      options.IdleTimeout = TimeSpan.FromSeconds(1000);
      options.Cookie.HttpOnly = true;
      options.Cookie.IsEssential = true;
      });

      services.AddRazorPages();

      // configure the Entity Framework context passing the connection string
      services.AddDbContext<GameContext>(options => options.UseSqlite(Configuration.GetConnectionString("GameContext")));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthorization();

      // allow session state via cookies
      app.UseSession();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapRazorPages();
      });
    }
  }
}
