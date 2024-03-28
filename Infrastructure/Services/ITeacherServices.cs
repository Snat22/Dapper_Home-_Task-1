using Domain;

namespace Infrastructure;

public interface ITeacherServices
{
    List<Teacher> GetTeachers();
    Teacher GetTeacherById(int id);
    string  AddTeacher(Teacher teacher);
    string  UpdateTeacher(Teacher teacher);

    bool DeleteTeacher(int id);
}
