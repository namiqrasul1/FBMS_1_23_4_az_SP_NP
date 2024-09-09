namespace Lesson8ParallelPlinq.Models;

public class AddStudentDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }

    // implicit operator overload
    public static implicit operator Student(AddStudentDto dto)
    {

        return new Student
        {
            Email = dto.Email,
            Group = "FBAS",
            Mark = 0,
            Name = dto.Name,
            Surname = dto.Surname,
        };
    }
    // explicit operator overload
    //public static explicit operator Student(AddStudentDto dto)
    //{
        
    //    return new Student
    //    {
    //        Email = dto.Email,
    //        Group = "FBAS",
    //        Mark = 0,
    //        Name = dto.Name,
    //        Surname = dto.Surname,
    //    };
    //}

}
