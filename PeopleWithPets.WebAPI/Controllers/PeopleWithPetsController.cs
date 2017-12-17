using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PeopleWithPets.Domain.Service;
using PeopleWithPets.Domain.Repository;
using Microsoft.Extensions.Logging;

namespace PeopleWithPets.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PeopleWithPetsController : Controller
    {
        private readonly PeopleWithPetsRepository _repository;
        private readonly ILogger<PeopleWithPetsController> _logger;


        public PeopleWithPetsController(PeopleWithPetsRepository repository, ILogger<PeopleWithPetsController> logger)
        {
            if(repository == null)
            {
                throw new ArgumentNullException(nameof(repository));
            }
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            _repository =repository;
            _logger = logger;
        }
        // GET api/values
        [HttpGet]
        public ActionResult GetCatsGroupedByOwnersGender()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _logger.LogInformation("Calling GetCatsGroupedByOwnersGender method");
                    var peopleWithPetsService = new PeopleWithPetsService(_repository);
                    return Ok(peopleWithPetsService.GetCatsGroupedByOwnersGender());
                }
                return BadRequest(ModelState);
            }
            catch (Exception)
            {
                _logger.LogError("Failed while executing GetCatsGroupedByOwnersGender");
                return BadRequest(new { Reason = "Error Occurred" });
            }
        }
    }
}
