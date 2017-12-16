using System.Collections.Generic;

namespace PeopleWithPets.Domain.Repository
{
    public abstract class PeopleWithPetsRepository
    {
        public abstract IEnumerable<Models.CatsWithOwnersGender> GetAllCatsWithOwnersGender();
    }
}