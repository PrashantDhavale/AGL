using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PeopleWithPets.DataAccess.Settings;

namespace PeopleWithPets.DataAccess.Repository
{
    public class HttpClientPeopleWithPetsRepository : Domain.Repository.PeopleWithPetsRepository
    {
        private readonly IOptions<RepositorySettings> _settings;

        public HttpClientPeopleWithPetsRepository(IOptions<RepositorySettings> settings)
        {
            if(settings == null)
            { 
                throw new ArgumentNullException(nameof(settings));
            }

            _settings = settings;
        }

        public override IEnumerable<Domain.Models.CatsWithOwnersGender> GetAllCatsWithOwnersGender()
        {
            var persons = LoadHttpClientData(_settings.Value.ServiceEndPoint);

            if (persons == null)
                return null;

            var query = from person in persons.Result
                        from pet in person.Pets.Where(p => p.Type == Domain.Enums.PetType.Cat).DefaultIfEmpty()
                        select new Domain.Models.CatsWithOwnersGender(person.Gender, pet?.Name);

            return query.Where(c => c.CatsName != null).OrderBy(petsName => petsName.CatsName);
        }

        private async Task<List<Domain.Models.Person>> LoadHttpClientData(string baseUrl)
        {
            List<Domain.Models.Person> persons;
            var jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            };

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                persons = !string.IsNullOrEmpty(data)
                             ? JsonConvert.DeserializeObject<List<Domain.Models.Person>>(data, jsonSettings)
                             : default(List<Domain.Models.Person>);
            }

            return persons;
        }
    }
}