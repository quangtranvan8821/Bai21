using Microsoft.EntityFrameworkCore;
using Bai21_TranVanQuang.Models;

namespace Bai21_TranVanQuang.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<LaiXe> tblLaiXe { get; set; } = default!;
        public DbSet<DanhGiaLaiXe> tblDanhGiaLaiXe { get; set; } = default!;

    }
}