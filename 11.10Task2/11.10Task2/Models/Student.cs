using System;
namespace _11._10Task2.Models
{
	public class Student: Person
	{
        private bool _isonline;

        public bool IsOnline
        {
            get { return _isonline; }
            set { _isonline = value; }
        }
        public Student(string name, string surname, byte age, bool isonline) : base(name, surname, age)
        {
            IsOnline = isonline;
        }
    }
}

