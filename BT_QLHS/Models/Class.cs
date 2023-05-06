using System.ComponentModel.DataAnnotations;

namespace BT_QLHS.Models
{
    public class Class
    {
        [Range(0, int.MaxValue)]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Bat buoc nhap truong nay!!")]
        public string ClassName { get; set; }
        [MinLength(5)]
        public string ClassCode { get; set; }
        [Range(1,int.MaxValue, ErrorMessage = "Toi thieu lon hon 0!")]
        public int ClassMaxSize { get; set; }
    }
}
