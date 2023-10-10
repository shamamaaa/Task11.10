using System;
namespace _11._10Task2.Models
{
	public class Group
	{
		private string _groupname;
		public string GroupName
		{
			get { return _groupname; }

			set { _groupname = value; }
		}

		private Student[] _students;

		public Student[] Students
		{
			get { return _students; }
		}

		public Group(string groupname)
		{
			GroupName = groupname;
			_students = new Student[0];
		}


		//Methods

		public void AddStudent(Student student)
		{
			Array.Resize(ref _students, Students.Length+1);
			Students[Students.Length - 1] = student;
		}

		public void GetAll()
		{
			Console.WriteLine($"Qrup: {GroupName}");

			foreach (var student in Students)
			{
				Console.WriteLine($"Ad: {student.Name} Soyad: {student.Surname}");
			}
		}

		public void GetOnlineStudents()
		{
            Console.WriteLine($"Qrup {GroupName} online oxuyan telebeler: ");

            foreach (var student in Students)
            {
                if (student.IsOnline)
                {
                    Console.WriteLine($"Ad:{student.Name} Soyad:{student.Surname}");
                }
            }
        }

        public void GetOfflineStudents()
        {
            Console.WriteLine($"Qrup {GroupName} offline oxuyan telebeler: ");

            foreach (var student in Students)
            {
                if (!student.IsOnline)
                {
                    Console.WriteLine($"Ad:{student.Name} Soyad:{student.Surname}");
                }
            }
        }

    }
}

