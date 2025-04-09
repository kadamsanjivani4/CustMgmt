using System.ComponentModel.DataAnnotations;

namespace CustMgmt.Models
{
    public class CustomerDetails
    {
        [Key]
        public int CustomerId { get;set;}
        public string FirstName { get;set;}
        public string LastName { get;set;}
        public string PrimaryContactNo { get; set; }
        public string AltContactNo  { get; set; }
        public string Email { get;set;}
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string District { get; set; }
        public string States { get; set; }
        public string Country   { get; set; }
        public string PinCode { get; set; }
        public string UID { get; set; }
        public string PAN { get; set; }
        public string Occupation { get; set; }
    }
}
