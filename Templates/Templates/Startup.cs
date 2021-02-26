using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Dal.Models;
using Microsoft.EntityFrameworkCore;

[assembly: FunctionsStartup(typeof(@@ProjectName.Startup))]
namespace @@ProjectName
{
    class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
           
            @@ifKeyvault
           
        }
    }
}
