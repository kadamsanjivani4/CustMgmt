using Microsoft.EntityFrameworkCore;

namespace CustMgmt.Models
{
    public class CMSDbContext: DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options) : base(options)
        {
        }

        public DbSet<CustomerDetails> customerDetails { get; set; }
        public DbSet<AccountDetails> accountDetails { get; set; }
        public DbSet<AccountStatus> accountStatus { get; set; }
        public DbSet<EmployeeDetails> employeeDetails { get; set; }
        public DbSet<EmpRoles> empRoles { get; set; }


    }
}
