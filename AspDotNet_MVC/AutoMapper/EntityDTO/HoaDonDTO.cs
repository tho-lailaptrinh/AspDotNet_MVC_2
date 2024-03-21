namespace AspDotNet_MVC.AutoMapper.EntityDTO
{
    public class HoaDonDTO
    {
        public Guid Id { get; set; }
        public decimal? TongTien { get; set; }
        public DateTime? NgayTao { get; set; } // ngày bán
        public int? TrangThai { get; set; } // trạng thái
    }
}
