using WorkflowManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowManagement
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<PackageServices> PackageServices { get; set; }
        public DbSet<WorkOrderServices> WorkOrderServices { get; set; }
        public DbSet<WorkOrderPackages> WorkOrderPackages { get; set; }
    }
}
