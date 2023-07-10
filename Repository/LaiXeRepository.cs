using Bai21_TranVanQuang.Interfaces;
using Bai21_TranVanQuang.Data;
using Bai21_TranVanQuang.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai21_TranVanQuang.Repositories
{
    public class LaiXeRepository : ILaiXeRepository
    {
        private readonly ApplicationDbContext _context;

        public LaiXeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LaiXe>> GetAll()
        {
            return await _context.tblLaiXe!.ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}