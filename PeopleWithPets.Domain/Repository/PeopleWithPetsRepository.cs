using System.Collections.Generic;

namespace PeopleWithPets.Domain.Repository
{
    public abstract class PeopleWithPetsRepository
    {
        public abstract IEnumerable<Domain.Models.CatsGroupedByOwnersGender> GetCatsGroupedByOwnersGender();
    }
}