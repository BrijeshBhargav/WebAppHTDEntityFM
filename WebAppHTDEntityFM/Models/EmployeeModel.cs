using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EMPID { get; set; }
        public string EMPName { get; set; }
        public string EMPMailid { get; set; }
        public DateTime EMPDOB { get; set; }
        public string EMProle { get; set; }
        public string Empsalary { get; set; }
        public DateTime EMPDOJ { get; set; }
    }
}
