﻿namespace MvvmDemo.Model
{
    public class PersonModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonModel(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
