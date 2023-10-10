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


        private byte _age;
        public byte Age
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

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}

