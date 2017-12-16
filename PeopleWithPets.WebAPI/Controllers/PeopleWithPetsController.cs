using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleWithPets.Domain.Service;
using PeopleWithPets.Domain.Repository;

namespace PeopleWithPets.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PeopleWithPetsController : Controller
    {
        private readonly PeopleWithPetsRepository _repository;
        public PeopleWithPetsController(PeopleWithPetsRepository repository)
        {
            if(repository == null)
            {
                throw new ArgumentNullException(nameof(repository));
            }

            _repository=repository;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Domain.Models.CatsWithOwnersGender> GetPetsGroupedByOwnersGender()
        {
            var peopleWithPetsService = new PeopleWithPetsService(_repository);
            return peopleWithPetsService.GetAllCatsByNameAndOwnersGender();
        }
    }
}
