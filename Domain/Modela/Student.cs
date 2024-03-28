namespace Domain;

public class Student
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName  { get; set; } 
    public required int Age { get; set; }
    public required string Email { get; set; }
    public required string Address { get; set; }
}
