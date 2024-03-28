

using Domain;
using Infrastructure;

var stdServices = new StudentService();

var teacheService = new TeacherServices();
// var std = new Student()
// {
//     Id = 1,
//     FirstName = "Muhammad",
//     LastName = "Azamov",
//     Age = 20,
//     Email = "Azamov05@gmail.com",
//     Address = "Dushanbe"
// };
// stdServices.AddStudent(std);

var teacher = new Teacher()
{
    Id = 3,
    FirstName = "test2",
    LastName = "testov2",
    Subject = "C++",
    Age = 22,
    Experience = 3
};
// teacheService.AddTeacher(teacher);
// foreach (var item in teacheService.GetTeachers())
// {
//     System.Console.WriteLine(item.LastName);
// }
teacheService.DeleteTeacher(9);