namespace AspDotNet_MVC.AutoMapper.EntityDTO
{
    public class SanPhamDTO
    {
        public Guid Id { get; set; }
        public string? Ten { get; set; }
        public decimal? Gia { get; set; }
        public int? SoLuong { get; set; }

        public string? TenDMSP { get; set;}
    }
}
