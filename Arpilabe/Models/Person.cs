using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Arpilabe.Models
{
    public class Person
          {
            public String firstName  { get; set; }

            [Required]
            public string lastName { get; set; }

        [Required]
        public string eMail { get; set; }

        [Required]
        public int phone { get; set; }

        [Required]
        public String note { get; set; }

        [Required]
        public String Departement { get; set; }

        [Required]
        public DateTime dateOfBirth { get; set; }



        [Required]
            [Range(minimum: 0.01, maximum: (double)decimal.MaxValue)]
            public decimal Price { get; set; }
        }
}
