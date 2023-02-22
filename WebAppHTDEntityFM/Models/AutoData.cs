using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class AutoData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Address { get; set; }
    }
}
