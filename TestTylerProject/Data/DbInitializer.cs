using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TestTylerProject.Models;

namespace TestTylerProject.Data
{
    public class DbInitializer
    {
        public static void Initialize(CharacterContext context)
        {
            context.Database.EnsureCreated();

            if (context.Characters.Any())
            {
                return;
            }

            var characters = new List<Character>
            {
                new Character { Name = "Reek" },
                new Character { Name = "Tylo Ren" },
                new Character { Name = "Jon Snow" },
            };

            foreach (var character in characters)
            {
                context.Characters.Add(character);
            }

            context.SaveChanges();
        }
    }
}
