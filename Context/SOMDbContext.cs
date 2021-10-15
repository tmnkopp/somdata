using Microsoft.EntityFrameworkCore; 
using SOMData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMData
{
    public class SOMDbContext: DbContext  
    {

        public SOMDbContext( DbContextOptions options) :base(options)
        {

        }
        public virtual DbSet<CompilationWorkspace> CompilationWorkspaces { get; set; }
        public virtual DbSet<ConsoleCommand> ConsoleCommands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
