namespace BT_QLHS.Models
{
    public class Student
    {
        //Id, tên sinh viên, mã số sinh viên, ngày tháng năm sinh
        public int Id{ get; set; }
        public string Ten{ get; set; }
        public string MSSV{ get; set; }
        public DateTime DoB { get; set; }
    }
}
