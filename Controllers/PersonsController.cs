using FormApplicationApiDotNet.ApiDbContext;
using FormApplicationApiDotNet.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormApplicationApiDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly FormApiDbContext context;

        public PersonsController(FormApiDbContext context)
        {
            this.context = context;
        }
        [HttpGet("GetAllContacts")]
        public IActionResult GetAllContacts()
        {
            var item = context.Persons.ToList();
            return Ok(item);
        }
        [HttpPost("AddPerson")]
        public IActionResult AddPerson(PersonDto personDto)
        {
            var person = new Person
            {
                Id = Guid.NewGuid(),
                Name = personDto.Name,
                Email = personDto.Email,
                Company = personDto.Company,    
                ReasonForContact = personDto.ReasonForContact,
                MoreDetails = personDto.MoreDetails,
                Phone = personDto.Phone,
                
            };
            context.Persons.Add(person);
            context.SaveChanges();
            return Ok();
        }
    }
}
