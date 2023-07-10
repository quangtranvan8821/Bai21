namespace Bai21_TranVanQuang.Models;
using System.ComponentModel.DataAnnotations;

public class LaiXe
{

    [Key]
    public int iLaixeID { get; set; }
    public string sHoten { get; set; }
    public Boolean bGioitinh { get; set; }
    public DateTime dNgaysinh { get; set; }
    public string sDiachi { get; set; }
}