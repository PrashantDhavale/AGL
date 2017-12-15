using System;
using System.Collections.Generic;

namespace PeopleWithPets.Domain.Models
{
    public class Person
    {
        private readonly string _name;
        private readonly string _gender;
        private readonly long _age;
        private readonly List<Pet> _pets;

        public string Name{get{return _name;}}
        public string Gender{get{return _gender;}}
        public long Age{get{return _age;}}
        public List<Pet> Pets{get{return _pets;}}

        public Person(string name,string gender,long age,List<Pet> pets)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if(string.IsNullOrEmpty(gender))
            {
                throw new ArgumentNullException(nameof(gender));
            }

            _name = name;
            _gender = gender;
            _age = age;
            _pets = pets;
        }
    }
}