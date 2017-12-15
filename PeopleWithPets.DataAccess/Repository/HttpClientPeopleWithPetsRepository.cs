using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;

namespace PeopleWithPets.DataAccess.Repository
{
    public class HttpClientPeopleWithPetsRepository : Domain.Repository.PeopleWithPetsRepository
    {
        private readonly string _serviceEndPoint;
        private List<Domain.Models.Person> _persons;

        public HttpClientPeopleWithPetsRepository(string serviceEndPoint)
        {
            if(string.IsNullOrEmpty(serviceEndPoint))  
            {
                throw new ArgumentNullException(nameof(serviceEndPoint));
            }

            _serviceEndPoint = serviceEndPoint;
            LoadHttpClientData(_serviceEndPoint);
        }

        public override IEnumerable<Domain.Models.CatsByOwnersGender> GetAllCatsByOwnersGender()
        {
            if(_persons == null)
                return null;

            var result = (
                            from person in _persons
                            from pet in person.Pets.DefaultIfEmpty()
                            where pet.Type == "Cat"
                            select 
                            new Domain.Models.CatsByOwnersGender(person.Gender,pet.Name)
                          ).AsEnumerable();

            return result;
        }

        private async void LoadHttpClientData(string baseUrl)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                _persons = !string.IsNullOrEmpty(data) 
                             ? JsonConvert.DeserializeObject<List<Domain.Models.Person>>(data)
                             : default(List<Domain.Models.Person>);
            }
        }
    }
}