using Bogus;
using Lesson8ParallelPlinq.Models;

namespace Lesson8ParallelPlinq.Fakers;

public static class InitalizeStudents
{
    private static readonly Faker<Student> _faker;
    static InitalizeStudents()
    {
        _faker = new Faker<Student>();

        _faker.RuleFor(s => s.Id, f => f.IndexGlobal)
              .RuleFor(s => s.Name, f => f.Name.FirstName())
              .RuleFor(s => s.Surname, f => f.Name.LastName())
              .RuleFor(s => s.Email, f => f.Person.Email)
              .RuleFor(s => s.DateOfBirth, f => f.Person.DateOfBirth)
              .RuleFor(s => s.Group, f => f.Company.CompanyName())
              .RuleFor(s => s.Mark, f => f.Random.Float(1, 100));
    }

    public static List<Student> GenerateStudents(int count) => _faker.Generate(count);
}
