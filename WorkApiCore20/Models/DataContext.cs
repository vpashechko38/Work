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
        public DbSet<PartnerModel> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }
    }
}
