using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day10.Entities
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int StudentId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}