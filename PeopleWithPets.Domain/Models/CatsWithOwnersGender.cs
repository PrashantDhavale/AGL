using System;
using PeopleWithPets.Domain.Enums;

namespace PeopleWithPets.Domain.Models
{
    public class CatsWithOwnersGender
    {
        private readonly PersonGender _ownersGender;
        private readonly string _catsName;

        public PersonGender OwnersGender { get { return _ownersGender; } }

        public string CatsName { get { return _catsName; } }

        public CatsWithOwnersGender(PersonGender ownersGender, string catsName)
        {
            if (string.IsNullOrEmpty(catsName))
            {
                throw new ArgumentNullException(nameof(catsName));
            }

            _ownersGender = ownersGender;
            _catsName = catsName;
        }
    }
}