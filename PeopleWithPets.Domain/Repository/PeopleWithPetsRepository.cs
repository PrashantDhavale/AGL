using System.Collections.Generic;
using PeopleWithPets.Domain.Models;
using System.Threading.Tasks;

namespace PeopleWithPets.Domain.Repository
{
    public abstract class PeopleWithPetsRepository
    {
        public abstract IEnumerable<Domain.Models.CatsWithOwnersGender> GetAllCatsWithOwnersGender();
    }
}