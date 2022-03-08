using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using SampleGQL.Data;
using SampleGQL.Models;

namespace SampleGQL.GraphQL
{
    public class Query{
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Student> GetStudents([ScopedService] AppDbContext context)
        {
            return context.Students;
        }

        // public IQueryable<Student> Custom([Service] AppDbContext context)
        // {
        //     return null;
        // }
    }
}