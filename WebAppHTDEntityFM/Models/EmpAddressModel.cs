using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAppHTDEntityFM.Models
{
    public class EmpAddressModel
    {
        [Key]
        [ForeignKey("Employeee")]
        public int EMPID { get; set; }
        public string EMPADDRESS { get; set; }

        public virtual EmpModel Employeee { get; set; }

    }
}
