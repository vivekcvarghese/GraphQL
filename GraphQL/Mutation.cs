using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Data;
using SampleGQL.Data;
using SampleGQL.GraphQL.Students;
using SampleGQL.Models;

namespace SampleGQL.GraphQL{

    public class Mutation{
        
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddStudentDetail> AddStudentAsync(AddStudentInput input,
            [ScopedService] AppDbContext context){

                var student = new Student{
                    Name = input.Name,
                    Course = input.Course
                };

                context.Students.Add(student);
                await context.SaveChangesAsync();


                return new AddStudentDetail(student);
            }
    }
}
