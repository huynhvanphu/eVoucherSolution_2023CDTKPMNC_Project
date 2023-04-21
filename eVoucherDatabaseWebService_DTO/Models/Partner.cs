using eVoucherDatabaseWebService_DTO.Abtracts;

namespace eVoucherDatabaseWebService_DTO.Models
{
    [Table("Partners")]
    public class Partner: RootClass
    {
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Address { get; set; }
        
        [ForeignKey("PartnerCategoryID")]
        public virtual PartnerCategory Partnercategory { set; get; }

        [ForeignKey("UserID")]
        public AppUser AppUser { set; get; }
        public List<PartnerImage>? PartnerImages { get; set; }
    }
}