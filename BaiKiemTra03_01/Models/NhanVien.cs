using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_01.Models
{
    public class NhanVien
    {
        [Key]
        public int MaID { get; set; }

        [Required(ErrorMessage = "Tên nhân viên là bắt buộc")]
        public string TenNhanVien { get; set; }

        [Required(ErrorMessage = "Chức vụ là bắt buộc")]
        public string ChucVu { get; set; }

        [Required(ErrorMessage = "Mã phòng ban là bắt buộc")]
        public int MaPhongBan { get; set; } 

        [Required(ErrorMessage = "Ngày bắt đầu làm việc là bắt buộc")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
