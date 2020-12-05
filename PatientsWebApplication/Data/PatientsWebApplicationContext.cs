using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PatientsWebApplication.Models;

namespace PatientsWebApplication.Data
{
    public class PatientsWebApplicationContext : DbContext
    {
        public PatientsWebApplicationContext (DbContextOptions<PatientsWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<PatientsWebApplication.Models.Patient> Patient { get; set; }
    }
}
