using ChallengeTecnico_Ears.IService;
using ChallengeTecnico_Ears.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace ChallengeTecnico_Ears.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
       

        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        /* Se requiere que se haga uso del servicio ya creado previamente */ 

        /* Sera valorada la percepción y solución de posibles escenarios de error */

        public PersonController( ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)] //En caso de utilizar autenticacion
        [ProducesResponseType(typeof(List<PersonModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            var response = await _personService.GetPersonList();

            return Ok(response);
        }
    }
}
