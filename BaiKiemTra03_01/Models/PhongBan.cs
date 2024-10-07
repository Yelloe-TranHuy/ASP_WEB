using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_01.Models
{
    public class PhongBan
    {
        [Key]
        public int MaPhongBan { get; set; }

        [Required(ErrorMessage = "Tên phòng ban là bắt buộc")]
        public string TenPhongBan { get; set; }
        public int SoLuongNhanVien { get; set; }

        [Required(ErrorMessage = "Mã phòng ban quản lý là bắt buộc")]
        public int MaPhongQL { get; set; }

    }
}
