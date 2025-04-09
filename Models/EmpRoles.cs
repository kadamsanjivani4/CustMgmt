using System.ComponentModel.DataAnnotations;
namespace CustMgmt.Models
{
    public class EmpRoles
    {
       [Key]
       public int UserId { get; set; }
       public string RoleName { get; set; }

    }
}
