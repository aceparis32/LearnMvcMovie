using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
//add more library
using Microsoft.Extensions.DependencyInjection; //Dependency Injection Library
using MvcMovie.Models;  //MvcMovie models

namespace MvcMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //add the seed initializer
            var host = BuildWebHost(args);
            
            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    //requires using RazorPagesMovie.Models;
                    SeedData.Initialize(services);
                }catch(Exception e)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "An error occured seeding the DB.");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
