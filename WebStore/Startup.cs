using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using WebStore.Infrastructure.Middleware;

namespace WebStore
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(opt =>
            {
                //opt.Conventions.Add(new WebStoreControlConvention());
            }).AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            //app.UseMiddleware<TestMiddleware>();
            //app.Map("/Hello",
            //    async context => context.Run(async request => await request.Response.WriteAsync("Hello world")));
            //app.MapWhen(
            //    context => context.Request.Query.ContainsKey("id") && context.Request.Query["id"] == "5",
            //    context => context.Run(async request => await request.Response.WriteAsync("Hello World with id:5!")));

            app.UseWelcomePage("/welcome");

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context => await context.Response.WriteAsync(_configuration["greetings"]));
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
