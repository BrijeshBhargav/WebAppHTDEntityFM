using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class Employee
    {
        [Key]
        public int EID { get; set; }
        public string EName { get; set; }
        public int salary { get; set; }
        public int BankID { get; set; }
        public Bank Bank { get; set; }
    }
}
