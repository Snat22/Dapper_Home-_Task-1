using Domain;

namespace Infrastructure;

public interface IStudentService
{
    List<Student> GetStudents();

    Student GetStudentById(int id);

    string  AddStudent(Student student);

    string UpdateStudent(Student student);

    bool DeleteStudent(int id);
}
