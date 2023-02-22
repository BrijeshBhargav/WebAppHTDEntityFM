using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class ProductsModel
    {
        [Key]
        public int PID { get; set; }
        public string PNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime EXPIRYDATE { get; set; }
        public decimal PRICE { get; set; }
     
    }
}
