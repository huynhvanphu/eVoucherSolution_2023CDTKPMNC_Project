using eVoucherDatabaseWebService_DTO.Abtracts;

namespace eVoucherDatabaseWebService_DTO.Models
{
    public class Game : RootClass
    {
        public virtual IEnumerable<CampaignGame> CampaignGames { set; get; }
    }
}