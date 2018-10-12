using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkApiCore20.Models
{
    public class DataContext:DbContext
    {
        public DbSet<LicenseModel> Licenses { get; set; }
        public DbSet<PartnerModel> Partners { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<VersionApp> Versions { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }
    }
}
