using AspDotNet_MVC.AutoMapper.EntityDTO;
using AspDotNet_MVC.Models.Entitis;

namespace AspDotNet_MVC.IRepositorys
{
    public interface ISanPhamRepo
    {
        public Task<IEnumerable<SanPhamDTO>> GetSanPhams();
        public Task<SanPham> CreateSP(SanPham sp);
        public Task<SanPham> UpdateSP(Guid id,SanPham sp);
        public Task<SanPham> DeleteSP(Guid id);  


    }
}
