namespace Task1;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double AvgMark { get; set;}

    public Student(string _name, int _age, double _avgmark) 
    {
        Name = _name;
        Age = _age;
        AvgMark = _avgmark;
    }    

}
