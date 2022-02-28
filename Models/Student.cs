using System.ComponentModel.DataAnnotations;

namespace SampleGQL.Models
{
    public class Student{
        [Key]
        public int Id { get; set; }
        [Required]
         public string Name { get; set; }
         public string Course { get; set; }
    }
}