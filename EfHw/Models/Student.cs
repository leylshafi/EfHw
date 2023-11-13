namespace EfHw.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public float AvgPoint { get; set; }

    public override string ToString()
    {
        return $"{Id}  {Name}  {Surname}  {AvgPoint}";
    }
}
