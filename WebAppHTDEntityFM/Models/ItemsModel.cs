using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class ItemsModel
    {
        [Key]
        public int ITEMID { get; set; }
        public string ITEMNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime EXPIRYDATE { get; set; }
        public float ITEMPRICE { get; set; }
    }
}
