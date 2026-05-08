namespace CyberShieldApi.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Plan { get; set; } = string.Empty;
    }
}