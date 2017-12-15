using System;

namespace PeopleWithPets.Domain.Models
{
    public class CatsByOwnersGender
    {
        private readonly string _ownersGender;
        private readonly string _catsName;

        public string OwnersGender        {            get            {                return _ownersGender;            }        }

        public string CatsName        {            get            {                return _catsName;            }        }

        public CatsByOwnersGender(string ownersGender, string catsName)
        {
              if(string.IsNullOrEmpty(ownersGender))  
              {
                  throw new ArgumentNullException(nameof(ownersGender));
              }
              if(string.IsNullOrEmpty(catsName))  
              {
                  throw new ArgumentNullException(nameof(catsName));
              }
              _ownersGender = ownersGender;
              _catsName = catsName;
        }
    }
}