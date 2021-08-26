using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using Covid19Casos.Shared;

namespace Covid19Casos.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Obtiene la ruta actual (ejecutando assembly)
            //string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //// El nombre del archivo de base de datos sqlite    
            //string dbFileName = "Covid19Casos.db";
            //// Crea la ruta completa combinando las 2 anteriores.
            //string absolutePath = Path.Combine(currentPath, dbFileName);

            string cnnString = Configuration.GetConnectionString("Covid19Casos");
            // Se agrega el CORS.
            services.AddCors();

            // Habilita el uso de SQLite y le envia la ruta absoluta.
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite($"Filename={cnnString}"));
            services.AddCors();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseCors(builder => builder.WithOrigins("*"));
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
