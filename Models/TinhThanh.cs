using System.ComponentModel.DataAnnotations;

namespace _2526_2221050694_BaiThi.Models;
public class TinhThanh
{
    [Key]
    public string MaTinh { get; set; } = string.Empty;
    public string TenTinh { get; set; } = string.Empty;
}
