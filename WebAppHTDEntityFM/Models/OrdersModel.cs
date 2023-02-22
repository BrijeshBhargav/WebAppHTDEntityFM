using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class OrdersModel
    {
        [Key]
        public int ORDERID { get; set; }
        public string CUSTOMERID { get; set; }
        public string PAYMENTMODE { get; set; }
        public DateTime SHIPPDATE { get; set; }
        public string STATUS { get; set; }
    }
}
