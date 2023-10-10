using System;
namespace _11._10Task2.Models
{
	public class Person
	{
		private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 25)
                {
                    _name = value;

                }
                else
                {
                    Console.WriteLine("Ad duzgun daxil edilmedi");
                }
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length >=3 && value.Length<=25)
                {
                    _surname = value;

                }
                else
                {
                    Console.WriteLine("Soyad duzgun daxil edilmedi");
                }
            }
        }


        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value>0)
                {
                    _age = value;

                }
                else
                {
                    Console.WriteLine("Yas duzgun daxil edilmedi");
                }
            }
        }

        public Person(string name, string surname, int age)
        {
            (Name, Surname, Age) = (name, surname, age);
        }
    }
}

