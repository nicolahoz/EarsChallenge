using ChallengeTecnico_Ears.Context;
using ChallengeTecnico_Ears.IService;
using ChallengeTecnico_Ears.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTecnico_Ears.Services
{
    public class PersonService : IPersonService
    {

        private readonly ContextChallenge _context;
        public PersonService(ContextChallenge dbContext)
        {
            _context = dbContext;
        }


        public async Task<List<PersonModel>> GetPersonList()
        {
            /* Aquí será requerido implementar la lógica para llamar y recuperar los datos de la base 
               Se requiere recuperar los datos de las personas activas con sus respectivas oficinas  
               y luego filtrar a las personas con legajo mayor a 1003 */

            /* Será valorada la percepción y solución de posibles escenarios de error */

            const int MIN_EMPLOYEE_FILE = 1003;

            try
            {
                var filteredPeople = await _context.Set<PersonModel>()
                        .Where(p => p.Active && p.EmployeeFile > MIN_EMPLOYEE_FILE)
                        .Include(p => p.Offices)
                        .AsNoTracking()
                        .ToListAsync();

                if (!filteredPeople.Any())
                {
                    //En alguna situacion se podria hacer un log o excepcion                    
                }


                return filteredPeople;
            }
            catch (TimeoutException tE)
            {
                throw new Exception("The operation has timed out", tE); //Puede ser util en casos de consultas muy grandes que tengan muchos Include/ThenInclude
            }
            catch (Exception ex) {
                throw new Exception("Unexpected database error", ex);
            }

        }



    }
}
