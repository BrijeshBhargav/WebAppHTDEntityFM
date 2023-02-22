using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class EmpModel
    {
        [Key]
        public int EMPID { get; set; }
        public string EMPNAME { get; set; }    
        public virtual EmpAddressModel EmpAdd { get; set; } 
    }
}
