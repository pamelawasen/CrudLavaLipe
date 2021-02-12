using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LavaLipe.Models;

namespace LavaLipe.Data
{
    public class LavaLipeContext : DbContext
    {
        public LavaLipeContext (DbContextOptions<LavaLipeContext> options)
            : base(options)
        {
        }

        public DbSet<LavaLipe.Models.ClienteModel> ClienteModel { get; set; }
        public DbSet<LavaLipe.Models.AgendaModel> AgendaModels { get; set; }
    }
}
