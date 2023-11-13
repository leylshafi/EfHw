using EfHw.DAL;
using EfHw.Models;

namespace EfHw.Services;

public class StudentService
{
    private static readonly AppDbContext _context=new();
    public List<Student> GetAll()
    {
        return _context.Students.ToList();
    }

    public Student? GetById(int id)
    {
        return _context.Students.Find(id);
    }
	
    public  void Create(Student student)
    {
         _context.Students.Add(student);
         _context.SaveChanges();
    }
    public  void CreateRange(List<Student> students)
    {
         _context.Students.AddRange(students);
         _context.SaveChanges();
    }

    public void Delete(int id)
    {
        if (GetById(id) is not null)
        {
            _context.Students.Remove(GetById(id));
            _context.SaveChanges();
        }
        else throw new Exception("Student not found");
    }
}
