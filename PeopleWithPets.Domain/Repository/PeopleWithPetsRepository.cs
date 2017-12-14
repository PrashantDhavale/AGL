using System.Collections.Generic;
using PeopleWithPets.Domain.Models;

namespace PeopleWithPets.Domain.Repository
{
    public abstract class PeopleWithPetsRepository
    {
        public abstract IEnumerable<CatsByOwnersGender> GetAllCatsByOwnersGender();
    }
}