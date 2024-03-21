using AspDotNet_MVC.AutoMapper.EntityDTO;
using AspDotNet_MVC.IRepositorys;
using AspDotNet_MVC.Models.Data;
using AspDotNet_MVC.Models.Entitis;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AspDotNet_MVC.Repositorys
{
    public class SanPhamRepo : ISanPhamRepo
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;
        public SanPhamRepo(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SanPhamDTO>> GetSanPhams()
        {
             var automap =  _context.SanPhams.ProjectTo<SanPhamDTO>(_mapper.ConfigurationProvider);
             var result = await automap.ToListAsync();
             return result;
        }
        public async Task<SanPham> CreateSP(SanPham sp)
        {
            SanPham sanpham = new SanPham()
            {
                Ten = sp.Ten,
                Gia = sp.Gia,
                SoLuong = sp.SoLuong,
                IdDMSP = Guid.NewGuid(),

            };
            _context.SanPhams.Add(sanpham);
             await _context.SaveChangesAsync();
            return sanpham;
        }
        public async Task<SanPham> UpdateSP(Guid id, SanPham sp)
        {
            var updateSP = await _context.SanPhams.FirstOrDefaultAsync(x => x.Id == id);
            updateSP.Ten = sp.Ten;
            updateSP.Gia = sp.Gia;
            updateSP.SoLuong = sp.SoLuong;
            _context.SanPhams.Update(sp);
            await _context.SaveChangesAsync();
            return updateSP;
        }
        public async Task<SanPham> DeleteSP(Guid id)
        {
            var deleteSP = await _context.SanPhams.FirstOrDefaultAsync(x => x.Id == id);
            _context.SanPhams.Remove(deleteSP);
            await _context.SaveChangesAsync();
            return deleteSP;
              
        }

    }
}
