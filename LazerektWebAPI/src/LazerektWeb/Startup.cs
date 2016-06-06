using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using System.Data.SqlClient;
using System.Web.Configuration;
using System;
using System.Diagnostics;

namespace LazerektWeb
{
    public class Startup
    {
        static public SqlConnection dbConnection;

        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
            Debug.Write("CONN_STRING" + WebConfigurationManager.ConnectionStrings["Database"].ToString());
            try {
                dbConnection = new SqlConnection(WebConfigurationManager.ConnectionStrings["Database"].ToString());
                dbConnection.Open();
            } catch(NullReferenceException e) {
                Debug.Write("Greska: " + e.ToString());
            } catch(SqlException e) {
                Debug.Write("SQL Greska: " + e.ToString());
            }
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            app.UseMvc();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
