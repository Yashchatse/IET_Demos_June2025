using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _45EntityFramework.Models
{
    [Table("Cust")]
    public class Customer
    {
        [Key]
        [Column("Id",TypeName ="int")]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column("BNo", TypeName = "int")]
        public int  BillNo { get; set; }
    }
}
