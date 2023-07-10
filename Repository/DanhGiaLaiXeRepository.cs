using Bai21_TranVanQuang.Interfaces;
using Bai21_TranVanQuang.Data;

namespace Bai21_TranVanQuang.Repositories
{
    public class DanhGiaLaiXeRepository : IDanhGiaLaiXeRepository
    {
        private readonly ApplicationDbContext _context;

        public DanhGiaLaiXeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}