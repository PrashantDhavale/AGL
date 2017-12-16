using System;
using PeopleWithPets.Domain.Repository;
using System.Collections.Generic;

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

        public IEnumerable<Domain.Models.CatsGroupedByOwnersGender> GetCatsGroupedByOwnersGender()
        {
            var result = _repository.GetCatsGroupedByOwnersGender();
            return result;
        }
    }
}
