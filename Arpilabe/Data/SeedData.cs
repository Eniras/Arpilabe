using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Arpilabe.Models;

namespace Arpilabe.Data
{
    public class SeedData
    {
     static readonly  String[,] MyArray = new String[,]
        {
                {"Marie", "Bresnu","marie.B@outlook.fr","0502010605","It"},
                {"Sophie", "Grease", "S.Grease@gmail.fr","0954400232","It"},
                {"James","Poney", "James.p@outlook.fr","0102558251","Marketing" },
                {"Jean","Brouard","j@outlook.fr ","0725262322", "Vente"},
                {"Michel", "Durand","Michel.Brouard@outlook.fr","0955471165","It"},
                {"Frederique", "Smith","Frederique@wanadoo.fr","0125023600", "Finance"},
                {"Sofia", "Lorignant","Sofia@gmail.com","0911525002","Marketing"},
                {"Paul", "Penny", "Paul@outlook.fr","0900152265","It"},
                {"Eleonore", "Destholoier","Eleonore@gmail.com","0248524511","Marketing"},
                {"Elfie", "Tougne","Elfie.societeS@wanadoo.fr","0951111232","Human Ressources"},
                {"Solenn","Languy","solenn.t@outlook.fr","0925113354","It"},
                {"Eric", "Buy","eric.eric@orange.fr","0111525484","Marketing"},
                {"Jean-Francois", "Patou","Jf@orange.fr","0325259965","Human Ressources"},
                {"Maria", "Chassaing","Maria@wanadoo.fr","0245695852","It"},
                {"Alienor", "Tournemand","Eleonore@gmail.fr","0255698741","Finance"},
                {"Sandra","Tougne","Sandra@lycos.fr","0156584555","Finance"},
                {"Amelie","Cordou","Amelie654@outlook.fr","0254876584", "Human Ressources"},
                {"Nolwenn","Armandiel", "Nolwenn.g@gmail.com","0954876254","It"},
                {"Pierre-Baptiste", "Dupont","PierreBaptiste@wanadoo.fr","0925365489","Marketing"},
                {"Amine","BenFaida","Amine@gmail.com","0502010605","It"}
        };
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
     
                for(int i = 0; i <20; i++)
                {
            
                        Person person1 =new Person
                        {
                            FirstName = MyArray[i,0],
                            LastName = MyArray[i,1],
                            Email = MyArray[i,2],
                            Phone = MyArray[i,3],
                            Departement = MyArray[i,4],
                        };
                    context.Add(person1);
                    
                }


                context.SaveChanges();
            }
    
        }
    }



}

