using Microsoft.EntityFrameworkCore;

namespace task_day_2_entityf_ramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using (var context = new appdbcontent())
            {
                //context.Students.Add(new student { fullname = "John Doe", age = 20, Email = "john@test.com" ,percent = 85});
                //var update = context.Students.Find(2);
                //update.age = 40;
                //context.Update(update);
                //var delete = context.Students.Find(3);
                //context.Students.Remove(delete);
                //context.SaveChanges();

                //var studentss = context.Students.Select(s => s.fullname).ToList();
                //foreach (var student in studentss)
                //{
                //    Console.WriteLine(student);
                //}
                //var student = context.Students
                //.Include(s => s.Courses)
                //    .ThenInclude(c => c.instructor);


                //var students = context.Students.ToList();

                //foreach (var student in students)
                //{
                //    Console.WriteLine($"ID:{student.Id}  Student: {student.fullname}, Age: {student.age}, Email: {student.Email}, Percent: {student.percent}");
                //}
            }
        }
    }
}
