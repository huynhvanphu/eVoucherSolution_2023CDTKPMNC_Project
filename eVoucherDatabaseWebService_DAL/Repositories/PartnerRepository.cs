using eVoucherDatabaseWebService_DAL.InfraStructure;

namespace eVoucherDatabaseWebService_DAL.Repositories
{
    public interface IPartnerRepository : IRepository<Partner>
    {
    }

    public class PartnerRepository : RepositoryBase<Partner>, IPartnerRepository
    {
        public PartnerRepository(eVoucherDbContext context) : base(context)
        {
        }
    }
}