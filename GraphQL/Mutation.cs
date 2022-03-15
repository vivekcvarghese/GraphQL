using System;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Data;
using SampleGQL.Data;
using SampleGQL.GraphQL.Students;
using SampleGQL.Models;

namespace SampleGQL.GraphQL{

    public class Mutation{
        
        [UseDbContext(typeof(AppDbContext))]
        public async Task<StudentDetail> AddStudentAsync(AddStudentInput input,
            [ScopedService] AppDbContext context){

                var student = new Student{
                    Name = input.Name,
                    Course = input.Course
                };

                context.Students.Add(student);
                await context.SaveChangesAsync();


                return new StudentDetail(student);
            }

         
        [UseDbContext(typeof(AppDbContext))]
        public async Task<StudentDetail> EditStudentAsync(EditStudentInput input,
            [ScopedService] AppDbContext context){

                    var student = context.Students.First(i => i.Id == input.Id);
                    student.Course = input.Course;
                    student.Name = input.Name;

                    await context.SaveChangesAsync();

                    return new StudentDetail(student);

            }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<StudentDetail> DeleteStudentAsync(DeleteStudentInput input,
            [ScopedService] AppDbContext context){

                    var student = context.Students.First(i => i.Id == input.Id);
                    context.Students.Remove(student);
                    await context.SaveChangesAsync();

                    return new StudentDetail(student);

            }

        

    }
}
