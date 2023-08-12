using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF.Models.context
{
    internal class EmployeeManagement : DbContext 
    {
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        { 

        optionsBuilder.UseSqlServer("data source = LAPTOP-FHUR50NT\\SQLEXPRESS02; " +
            "initial catalog = EmployeeManagement; " +
            "integrated security=SSPI; " +
            "TrustServerCertificate=True;");
    }
    }
}
