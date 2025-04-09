using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CustMgmt.Models
{
    public class AccountStatus
    {
        [Key]
        public int CustomerId { get; set; }
        public int CMSAgent { get; set; }
        public string RequestType { get; set; }
        public DateTime AppliedOn { get; set; }
        public string RequestStatus { get; set; }
        public string Remarks { get; set; }
    }
}
