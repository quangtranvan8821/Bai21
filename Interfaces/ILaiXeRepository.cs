using Bai21_TranVanQuang.Models;

namespace Bai21_TranVanQuang.Interfaces
{
    public interface ILaiXeRepository
    {
        public Task<IEnumerable<LaiXe>> GetAll();
    }
}