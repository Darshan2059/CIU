using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CIU.Models;

namespace CIU.Data
{
    public class CIUContext : DbContext
    {
        public CIUContext (DbContextOptions<CIUContext> options)
            : base(options)
        {
        }

        public DbSet<CIU.Models.Soap> Soap { get; set; }
    }
}
