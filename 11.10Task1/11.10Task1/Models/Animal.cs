using System;
namespace _11._10Task1.Models
{
	public class Animal
    {
		public DateTime _birthDate;
		public DateTime BirthDate { get { return _birthDate; } }

		public string _gender;
		public string Gender
		{
			get { return _gender; }
			init { _gender = value; }
		}

		public Animal(string gender)
		{
			_birthDate = DateTime.Now;

			Gender = gender;
		}

	}
}

