namespace Project.Entities;

public class Student : BaseEntity
{
    public string FullName { get; set; } = null!;
    public int Age { get; set; }
}
