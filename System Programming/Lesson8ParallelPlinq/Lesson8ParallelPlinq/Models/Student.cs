namespace Lesson8ParallelPlinq.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public float Mark { get; set; }
    public string Group { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }

    public override string ToString() => @$"Id: {Id} Name: {Name} Surname: {Surname}";

    

}
