namespace Bai21_TranVanQuang.Models;
using System.ComponentModel.DataAnnotations;


public class DanhGiaLaiXe
{
    [Key]
    public int iDanhgiaID { get; set; }
    public int iLaixeID { get; set; }
    public DateTime dNgaydanhgia { get; set; }
    public int iSosao { get; set; }
}