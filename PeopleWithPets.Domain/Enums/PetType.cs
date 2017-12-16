using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PeopleWithPets.Domain.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PetType
    {
        Cat = 0,
        Dog = 1,
        Fish = 2
    }
}