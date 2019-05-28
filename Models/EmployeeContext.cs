using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreModelTranslate.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options)
        {
        }
       public DbSet<Pen> Pens { get; set; }
       public DbSet<Employee> Employees { get; set; }
 
    }
}
