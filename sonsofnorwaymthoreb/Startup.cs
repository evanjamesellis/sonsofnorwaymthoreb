using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sonsofnorwaymthoreb.Services;
using sonsofnorwaymthoreb.Services.Calendar;
using sonsofnorwaymthoreb.Services.Home;
using sonsofnorwaymthoreb.Services.PhotoGallery;
using sonsofnorwaymthoreb.Services.Vennelag;

namespace sonsofnorwaymthoreb
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
            services.AddScoped<IHomePageEventData, InMemoryHomePageEvent>();
            services.AddScoped<IProgramsAndActivitiesData, InMemoryProgramsAndActivities>();
            services.AddScoped<ILutefiskDinnersData, InMemoryLutefiskDinners>();
            services.AddScoped<INewsletterData, InMemoryNewsletters>();
            services.AddScoped<IPhotoGalleryImageData, InMemoryPhotoGalleryImages>();
            services.AddScoped<ICalendarData, InMemoryCalendarEvents>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/AppException");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
