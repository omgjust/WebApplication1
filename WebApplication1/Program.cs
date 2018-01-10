using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Rest;
using Microsoft.Rest.Azure.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
           // test();
           // Console.ReadKey();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();


       /* public static async void test()
        {
            string test = "";
            ServiceClientCredentials serviceCreds = await ApplicationTokenProvider.LoginSilentAsync("d99dbd6a-490d-4264-811d-158e08f6e8a6", "1526ce4e-eefe-4e8b-b22e-89ce20d60a5b", "Cz5SNJGQdtrBmrQ1iUb0DSjMemudmSNgVirTjTLgUNw=");
            ResourceManagementClient resourceManagementClient = new ResourceManagementClient(serviceCreds)
            {
                SubscriptionId = "e12d93ab-42e6-41d0-83b8-beee3fba3065"
            };
            if(resourceManagementClient.ResourceGroups.CheckExistence("dennis"))
            {
                Console.WriteLine("exists");
            }
            else
            {
               Console.WriteLine("Nope");
            }
        }*/
    }
}
