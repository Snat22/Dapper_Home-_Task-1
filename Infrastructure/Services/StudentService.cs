using Domain;
using Npgsql;
using Dapper;
namespace Infrastructure;


public class StudentService : IStudentService
{
    private readonly string _connectionString= "Server=localhost;Port=5432;Database=Dapper_db2;User Id=postgres;Password=11223344";

    public string AddStudent(Student student)
    {
           using (var connection=new NpgsqlConnection(_connectionString))
        {
             var sql = $"INSERT INTO student (firstname,lastname,age,email,address)" +
                      $"values('{student.FirstName}', '{student.LastName}', {student.Age},'{student.Email}','{student.Address}')";
            var result = connection.Execute(sql);
            if (result > 0) return "Successfully added student";
             return "Failed to add student";
        }
                    }  
    

public List<Student> GetStudents()
    {
         using (var connection=new NpgsqlConnection(_connectionString))
        {
            var sql = "Select * from student";
            var result = connection.Query<Student>(sql);
            return result.ToList();
        } 
   }


    public Student GetStudentById(int id)
    {
    using (var connection=new NpgsqlConnection(_connectionString))
        {
            var sql = $"Select * from student where id = {@id}";
            var result = connection.QueryFirstOrDefault<Student>(sql);
            return result;
        }   
        
          }

    
    public string UpdateStudent(Student student)
    {
     
         using (var connection=new NpgsqlConnection(_connectionString))
        {
 var sql = $"Update Student SET firstname='{student.FirstName}'" +
                      $", lastname='{student.LastName}',age={student.Age}," +
                      $",email='{student.Email}',address='{student.Address}'" +
                      $"where id={student.Id}"; 

        var result = connection.Execute(sql);
        if (result > 0) return "Updated succesfully";
        return "Not found";
        
            
        }                  
    
       }


        public bool DeleteStudent(int id)
    {
       using (var connection=new NpgsqlConnection(_connectionString))
        {
            var sql = $"delete  from student as s where s.id={@id}";
            var result = connection.Execute(sql);
            if(result>0) return true;
            return false;
        } 
     }
}