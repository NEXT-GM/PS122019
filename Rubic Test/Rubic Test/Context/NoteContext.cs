using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rubic_Test.Models;

namespace Rubic_Test.Context
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) 
            : base (options)
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}
