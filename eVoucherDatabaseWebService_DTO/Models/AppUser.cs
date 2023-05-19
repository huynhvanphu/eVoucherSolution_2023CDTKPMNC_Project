using Microsoft.AspNetCore.Identity;

namespace eVoucher_DTO.Models
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>
    {
        public virtual IEnumerable<GamePlayResult>? GamePlayResults { get; set; }
        [ForeignKey("PartnerID")]
        public Partner? Partner { get; set; }
        [ForeignKey("CustomerID")]
        public Customer? Customer { get; set; }
        [ForeignKey("StaffID")]
        public Staff? Staff { get; set; }
    }
}