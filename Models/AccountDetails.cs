using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CustMgmt.Models
{
    public class AccountDetails
    {
        [Key]
        public int AccountNo { get; set; }
        public int CustomerId { get; set; }
        public int Balance { get; set; }
    }
}
