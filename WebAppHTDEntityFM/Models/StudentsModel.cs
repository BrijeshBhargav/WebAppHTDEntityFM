using System.ComponentModel.DataAnnotations;
namespace WebAppHTDEntityFM.Models
{
    public class StudentsModel
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentRollno { get; set; }
        public string StudentName { get; set; }
        public DateTime StudentDOB { get; set; }
        public string StudentMail { get; set; }
        public string StudentAddress { get; set; }
        public string StudentPhonenum { get; set; }
    }
}
