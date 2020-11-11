using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Arpilabe.Data;
using Arpilabe.Models;

namespace Arpilabe.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PersonController : ControllerBase

    {
        private readonly ArpilabeContext _context;

            public PersonController (ArpilabeContext context)
            {
                _context = context;
            }

            [HttpGet]
            public ActionResult<List<Person>> GetAll() =>
                _context.Persons.ToList();

            // GET by ID action

            // POST action

            // PUT action

            // DELETE action
    
    }
}


