using System;
namespace _11._10Task1.Models
{
	public class Dog: Animal
    {
        public string _breed;
        public string Breed
        {
            get { return _breed; }
            init { _breed = value; }
        }

        public string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Dog(string gender, string breed, string name) : base(gender)
        {
            Name = name;
            Breed = breed;
        }

        
    }
}

