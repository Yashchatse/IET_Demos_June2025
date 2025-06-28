using System.ComponentModel.DataAnnotations.Schema;

namespace _13Demo_EF_CodeFirst.Models
{
    [Table("Emp")]
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
