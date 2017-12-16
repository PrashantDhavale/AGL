using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PeopleWithPets.Domain.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonGender
    {
        Female = 0,
        Male = 1
    }
}