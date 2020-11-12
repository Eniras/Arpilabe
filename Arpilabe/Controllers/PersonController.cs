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
        // Ajout du controleur
        private readonly ArpilabeContext _context;

            public PersonController (ArpilabeContext context)
            {
                _context = context;
            }

            [HttpGet]
            public ActionResult<List<Person>> GetAll() =>
                _context.Persons.ToList();

        //Verbes d'action CRUD

        // GET by ID action lire
            [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetById (String id)
        {
            var person = await _context.Persons.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        // POST action creer
        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = person.FirstName }, person);
        }

        // PUT action modifier
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(String id, Person person)
        {
            if (id != person.FirstName)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }



        // DELETE action supprimer

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(String id)
        {
            var person = await _context.Persons.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}


