using System.ComponentModel.DataAnnotations;

namespace BT_QLHS.Models
{
    public class Student
    {
        //Id, tên sinh viên, mã số sinh viên, ngày tháng năm sinh
        [Range(1, int.MaxValue, ErrorMessage = "ID phải lớn hơn 0")]
        public int Id{ get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Ten bat buoc nhap")]
        public string Ten{ get; set; }

        public string MSSV{ get; set; }
        public DateTime DoB { get; set; }
    }
}
