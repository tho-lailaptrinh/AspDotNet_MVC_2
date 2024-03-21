using AspDotNet_MVC.AutoMapper.EntityDTO;
using AspDotNet_MVC.Models.Entitis;
using AutoMapper;

namespace AspDotNet_MVC.AutoMapper.ConfigMapper
{
    public class MappingConfigProfile : Profile
    {
        public MappingConfigProfile() 
        {
            CreateMap<User, UserDTO>();
            CreateMap<SanPham, SanPhamDTO>().ForMember(des => des.TenDMSP, src => src.MapFrom(act => act.DanhMucSanPhams.TenDM));
            CreateMap<HoaDon, HoaDonDTO>();
            CreateMap<HoaDonChiTiet, HoaDonChiTietDTO>();
            CreateMap<GioHang, GioHangDTO>();
            CreateMap<GioHangChiTiet, GioHangChiTietDTO>();
            CreateMap<ThanhToan, ThanhToanDTO>();
            CreateMap<Shipping, ShippingDTO>();
            CreateMap<DanhGiaSP, DanhGiaSanPhamDTO>();
            CreateMap<DanhMucSanPham, DanhGiaSanPhamDTO>();
        }
    }
}
