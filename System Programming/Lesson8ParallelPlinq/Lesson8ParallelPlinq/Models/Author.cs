using System;
using System.Collections.Generic;

namespace Lesson8ParallelPlinq.Models;

public partial class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
