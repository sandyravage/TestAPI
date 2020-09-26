using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestTylerProject.Models;

namespace TestTylerProject.Data
{
    public class CharacterContext : DbContext
    {
        public CharacterContext (DbContextOptions<CharacterContext> options)
            : base(options)
        {
        }

        public DbSet<TestTylerProject.Models.Character> Characters { get; set; }
    }
}
