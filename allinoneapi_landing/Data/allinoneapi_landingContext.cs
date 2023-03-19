#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using allinoneapi_landing.Models;
using Microsoft.Identity.Client;
//using System.Data.Entity;

namespace allinoneapi_landing.Data
{
    public class allinoneapi_landingContext : DbContext
    {
        public allinoneapi_landingContext (DbContextOptions<allinoneapi_landingContext> options)
            : base(options)
        {
        }
        protected override void ConfigureConventions(
    ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>()
                .HavePrecision(20, 10);
        }
    }
}
