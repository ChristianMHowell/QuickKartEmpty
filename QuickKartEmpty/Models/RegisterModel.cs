namespace QuickKartEmpty.Models
{
    public class RegisterModel
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? DisplayName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string? ReturnUrl { get; set; } = "/Home/Index";

    }
}
