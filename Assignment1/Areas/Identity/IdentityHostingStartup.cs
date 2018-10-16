using System;
using Assignment1.Areas.Identity.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Assignment1.Areas.Identity.IdentityHostingStartup))]
namespace Assignment1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Assignment1Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Assignment1ContextConnection")));

            });
        }
    }
}