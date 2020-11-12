using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Arpilabe.Models;

namespace Arpilabe.Data
{
    public class SeedData
    {
        // methode "Initialize" amorce la base de données en mémoire avec 1 personne
        public static void Initialize(ArpilabeContext context)
        {

            if (!context.Persons.Any())
            {
                context.Persons.AddRange();
                Person person = new Person
                {
                    FirstName = "Sandrine",
                    LastName = "Chastaing",
                    Email = "sandrine.chastaing@outlook.fr",
                    Phone = "0624303156",
                    Departement = "IT",
                };

                context.Add(person);

                context.SaveChanges();
            }
    
        }
    }



}

