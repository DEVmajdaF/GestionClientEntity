using gestionClient.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestionClient.Data
{
    public class gestionClientContext:DbContext
    {

        public gestionClientContext(DbContextOptions<gestionClientContext> options):base(options)
        {

        }

        public DbSet<Client> Client { get; set; }
    }
}
