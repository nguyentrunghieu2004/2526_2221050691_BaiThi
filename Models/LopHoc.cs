using System.ComponentModel.DataAnnotations;

namespace _2526_2221050691_BaiThi.Models
{
    public class LopHoc
    {
        [Key]
        public string MaLop { get; set; } = "";
        public string TenLop { get; set; } = "";
    }
}