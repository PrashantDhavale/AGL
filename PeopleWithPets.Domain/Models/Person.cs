using System;
using System.Collections.Generic;
using PeopleWithPets.Domain.Enums;

namespace PeopleWithPets.Domain.Models
{
    public class Person
    {
        private readonly string _name;
        private readonly PersonGender _gender;
        private readonly int _age;
        private readonly List<Pet> _pets;

        public string Name { get { return _name; } }
        public PersonGender Gender { get { return _gender; } }
        public int Age { get { return _age; } }
        public List<Pet> Pets { get { return _pets; } }

        public Person(string name, PersonGender gender, int age, List<Pet> pets)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            _name = name;
            _gender = gender;
            _age = age;
            _pets = pets;
        }
    }
}