using System;
using System.Collections.Generic;

namespace PeopleWithPets.Domain.Models
{
    public class Pet
    {
        private readonly string _name;
        private readonly string _type;

        public string Name {get{return _name;}}
        public string Type {get{return _type;}}
        
        public Pet(string name, string type)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if(string.IsNullOrEmpty(type))
            {
                throw new ArgumentNullException(nameof(type));
            }

            _name = name;
            _type = type;
        }
    }
}