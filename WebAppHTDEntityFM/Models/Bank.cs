using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class Bank
    {
        [Key]
        public int BankID { get; set; } 
        public string BankName { get; set; }
        public string Branch { get; set; }
    }
}
