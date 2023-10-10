using _11._10Task2.Models;

namespace _11._10Task2;
class Program
{
    static void Main(string[] args)
    {
        Group group = new("AB104");

        Student student1 = new("Shamama", "Guliyeva", 19, false);
        Student student2 = new("Zulfiyya", "Gurbanova", 19, true);
        Student student3 = new("Sabuhi", "Jamalzade", 19, true);
        Student student4 = new("Said", "Suleymanov", 18, false);


        group.AddStudent(student1);
        group.AddStudent(student2);
        group.AddStudent(student3);
        group.AddStudent(student4);

        group.GetAll();
        Console.WriteLine();
        group.GetOfflineStudents();
        Console.WriteLine();
        group.GetOnlineStudents();

    }
}

