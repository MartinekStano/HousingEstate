﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
       
        
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            
        }
        public override string ToString()
        {
            return ($"{Name} {Surname}\nVEK:{Age}");
        }
        public static Person NewPeopleInFlat(string name, string surname, int age)
        {
            Person person = new Person(name, surname, age);

            return person;
        }
    }
}
