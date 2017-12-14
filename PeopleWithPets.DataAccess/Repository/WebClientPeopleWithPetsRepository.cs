using System;
using System.Net.Http;
using System.Collections.Generic;

namespace PeopleWithPets.DataAccess.Repository
{
    public class WebClientPeopleWithPetsRepository : Domain.Repository.PeopleWithPetsRepository
    {
        private readonly string _serviceEndPoint;

        public WebClientPeopleWithPetsRepository(string serviceEndPoint)
        {
            if(string.IsNullOrEmpty(serviceEndPoint))  
            {
                throw new ArgumentNullException(nameof(serviceEndPoint));
            }

            _serviceEndPoint = serviceEndPoint;
        }

        public override IEnumerable<Domain.Models.CatsByOwnersGender> GetAllCatsByOwnersGender()
        {
            // using(var client = new HttpClient())
            // {
            //     var result = await client.GetAsync(_serviceEndPoint);
            // }
            return null;
        }
    }
}