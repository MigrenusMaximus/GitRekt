using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace LazerektWeb {
    public class Startup
    {
        static public SqlConnection dbConnection;
        static public SHA256 hashManager = new SHA256CryptoServiceProvider();

        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            hashManager.Initialize();

            try {
                dbConnection = new SqlConnection(Configuration["ConnectionStrings:AzureDatabase"]);
                dbConnection.Open();
            } catch(NullReferenceException e) {
                Debug.WriteLine("Greska: " + e.ToString());
            } catch(SqlException e) {
                Debug.WriteLine("SQL Greska: " + e.ToString());
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
