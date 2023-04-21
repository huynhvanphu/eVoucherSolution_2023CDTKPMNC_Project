using eVoucherDatabaseWebService_DAL.InfraStructure;

namespace eVoucherDatabaseWebService_DAL.Repositories
{
    public interface IGameRepository : IRepository<Game>
    {
    }

    public class GameRepository : RepositoryBase<Game>, IGameRepository
    {
        public GameRepository(eVoucherDbContext context) : base(context)
        {
        }
    }
}