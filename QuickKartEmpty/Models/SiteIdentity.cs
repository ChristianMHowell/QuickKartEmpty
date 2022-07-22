namespace QuickKartEmpty.Models
{
    public class SiteIdentity : IdentityUser
    {
        [PersonalData]
        public string? DisplayName { get; set; }

        [PersonalData]
        public DateTime BirthDate { get; set; }

        [ProtectedPersonalData]
        public string? SsNumber { get; set; }



    }
}
