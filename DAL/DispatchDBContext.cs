using Microsoft.EntityFrameworkCore;
using LogisticsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL
{
    public class DispatchDBContext : DbContext
    {

        public DispatchDBContext(DbContextOptions<DispatchDBContext> option) : base(option)
        {

        }

        public DbSet<WorkOrder> WorkOrder { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Truck_Trailer> Truck_Trailer { get; set; }
    }
}
