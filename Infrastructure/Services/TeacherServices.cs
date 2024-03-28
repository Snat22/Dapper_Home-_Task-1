using Dapper;
using Domain;

namespace Infrastructure;

public class TeacherServices : ITeacherServices
{
    private readonly DapperContext _context;
    public TeacherServices()
    {
        _context = new DapperContext();
    }
    public string AddTeacher(Teacher teacher)
    {
            var sql = $"Insert into teacher(firstname,lastname,subject,age,experience)"+
            $"values('{teacher.FirstName}','{teacher.LastName}','{teacher.Subject}',{teacher.Age},{teacher.Experience})";
            var inserted = _context.Connection().Execute(sql);
        if (inserted > 0) return "Successfully created new student";
         return "Error in creating new student";    
         }

    public List<Teacher> GetTeachers()
    {
        var sql = "Select * from teacher";
        var selected = _context.Connection().Query<Teacher>(sql).ToList();
        return selected;
    }

    public Teacher GetTeacherById(int id)
    {
        var sql = $"Select * from teacher where id = {@id}";
        var selected = _context.Connection().QueryFirstOrDefault<Teacher>(sql);
        return selected;
    }


    public string UpdateTeacher(Teacher teacher)
    {
        var sql = $"Update teacher set firstname = {teacher.FirstName}, lastname = {teacher.LastName}, subject = {teacher.Subject},age = {teacher.Age},experience = {teacher.Experience}";
         var updated = _context.Connection().Execute(sql);
         if(updated > 0) return "Updated succesfully";
         return "Not Found";
    }

        public bool DeleteTeacher(int id)
    {
        var sql = $"Delete from teacher where id = {@id}";
        var deleted = _context.Connection().Execute(sql);
        if(deleted > 0) return true;
        return false;
    }

}
