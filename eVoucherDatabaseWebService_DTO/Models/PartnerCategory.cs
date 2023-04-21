using eVoucherDatabaseWebService_DTO.Abtracts;


namespace eVoucherDatabaseWebService_DTO.Models
{
    [Table("PartnerCategories")]
    public class PartnerCategory : RootClass
    {
        public virtual IEnumerable<Partner> Partners { set; get; }
    }
}