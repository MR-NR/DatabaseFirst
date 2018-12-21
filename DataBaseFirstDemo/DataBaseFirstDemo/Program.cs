using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataBaseFirstDemoEntities();


            var student = new Student()
            {
                Name = "Nisar Ahmed",
                Programe ="BS(CS)",
                Date = DateTime.Now,
                StudentId = 1
            };

            context.Students.Add(student);

       
            context.SaveChanges();
            
        }
    }
}
