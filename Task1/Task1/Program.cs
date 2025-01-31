namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> Students = new List<Student>
        {
            new Student("Polina", 20, 8.3),
            new Student("Dima", 18, 7.63),
            new Student("Nikita", 19, 9.76)
        };

        Students.Sort((s1, s2) => s2.AvgMark.CompareTo(s1.AvgMark));
        foreach (Student student in Students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Average mark: {student.AvgMark}");
        }

        Students.Sort((s1,s2) => s1.Age.CompareTo(s2.Age));
        var LittleStud = Students[0];
        Console.WriteLine("The youngest student:");
        Console.WriteLine($"Name: {LittleStud.Name}, Age: {LittleStud.Age}, Average mark: {LittleStud.AvgMark}");

    }
}
