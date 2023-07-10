using Bai21_TranVanQuang.Interfaces;
using Bai21_TranVanQuang.Data;

namespace Bai21_TranVanQuang.Repositories
{
    public class LaiXeRepository : ILaiXeRepository
    {
        private readonly ApplicationDbContext _context;

        public LaiXeRepository(ApplicationDbContext context)
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