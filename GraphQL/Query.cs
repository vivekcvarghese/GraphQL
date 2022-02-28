using System.Linq;
using HotChocolate;
using SampleGQL.Data;
using SampleGQL.Models;

namespace SampleGQL.GraphQL
{
    public class Query{
        public IQueryable<Student> GetStudents([Service] AppDbContext context)
        {
            return context.Students;
        }

        // public IQueryable<Student> Custom([Service] AppDbContext context)
        // {
        //     return null;
        // }
    }
}