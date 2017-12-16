using System;
using PeopleWithPets.Domain.Repository;
using System.Collections.Generic;
using PeopleWithPets.Domain.Models;

namespace PeopleWithPets.Domain.Service
{
    public class PeopleWithPetsService
    {
        private readonly PeopleWithPetsRepository _repository;

        public PeopleWithPetsService(PeopleWithPetsRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException(nameof(repository));
            }
            _repository = repository;
        }

        public IEnumerable<CatsWithOwnersGender> GetAllCatsByNameAndOwnersGender()
        {
            var result = _repository.GetAllCatsWithOwnersGender();
            return result;
        }
    }
}
