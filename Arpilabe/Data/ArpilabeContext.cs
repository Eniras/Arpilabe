using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arpilabe.Models;
using Microsoft.EntityFrameworkCore;

        
namespace Arpilabe.Data
    {
    //Creation acces base de données mémoire
        public class ArpilabeContext : DbContext
        {
            public ArpilabeContext(DbContextOptions options)
                : base(options)
            {
            }

            public DbSet<Person> Persons { get; set; }
        }
    }


