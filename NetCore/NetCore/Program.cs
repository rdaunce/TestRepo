using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace NetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //new comment here!
            //adding another comment in a second commit
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();
            
            //adding a comment
            host.Run();
        }

        public static int function2() { return 2;  }

        public static int newFunction()
        {
            return 28;
        }
    }
}
