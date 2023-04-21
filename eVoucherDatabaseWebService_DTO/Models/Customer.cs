using eVoucherDatabaseWebService_DTO.Abtracts;
using eVoucherDatabaseWebService_Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVoucherDatabaseWebService_DTO.Models
{
    public class Customer: RootClass
    {
        public DateTime DOB { get; set; }
        public Sex Gender { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Address { get; set; }
                
        [ForeignKey("UserID")]
        public AppUser AppUser { set; get; }
    }
}
