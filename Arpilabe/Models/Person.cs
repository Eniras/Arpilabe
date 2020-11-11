using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Runtime.ExceptionServices;

namespace Arpilabe.Models
{
    public class Person
    {
        public String FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Phone { get; set; }

        [Required]
        public String Note { get; set; }

        [Required]
        public String Departement { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }


        [Required]

        String[,] MyArray = new String[,]
        {
                {"Marie", "Bresnu","marie.B@outlook.fr","0502010605","It"},
                {"Sophie", "Grease", "S.Grease@gmail.fr","0954400232","It"},
                {"James","Poney", "James.p@outlook.fr","010255448251","Marketing" },
                {"Jean","Brouard","j@outlook.fr ","0725262322", "Vente"},
                {"Michel", "Durand","Michel.Brouard@outlook.fr","0955471165","It"},
                {"Frederique", "Smith","Frederique@wanadoo.fr","0125023600", "Finance"},
                {"Sofia", "Lorignant","Sofia@gmail.com","0911525002","Marketing"},
                {"Paul", "Penny", "Paul@outlook.fr","0900152265","It"},
                {"Eleonore", "Destholoier","Eleonore@gmail.com","0248524511","Marketing"},
                {"Elfie", "Tougne","Elfie.societeS@wanadoo.fr","0951111232","Human Ressources"},
                {"Solenn","Languy","solenn.t@outlook.fr","0925113354","It"},
                {"Eric", "Buy","eric.eric@orange.fr","01115254845","Marketing"},
                {"Jean-Francois", "Patou","Jf@orange.fr","0325259965","Human Ressources"},
                {"Maria", "Chassaing","Maria@wanadoo.fr","024569585","It"},
                {"Eleonore", "Tournemand","Eleonore@gmail.fr","0255698741","Finance"},
                {"Sandra","Tougne","Sandra@lycos.fr","0156584555","Finance"},
                {"Amelie","Cordou","Amelie654@outlook.fr","0254876584", "Human Ressources"},
                {"Nolwenn","Armandiel", "Nolwenn.g@gmail.com","0954876254","It"},
                {"Pierre-Baptiste", "Dupont","PierreBaptiste@wanadoo.fr","0925365489","Marketing"},
                {"Amine","BenFaida","Amine@gmail.com","0502010605","It"}
        };

            


    }
}
