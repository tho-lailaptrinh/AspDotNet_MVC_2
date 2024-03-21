namespace AspDotNet_MVC.AutoMapper.EntityDTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public string? Role { get; set; }
    }
}
