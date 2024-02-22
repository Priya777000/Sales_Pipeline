using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Sales.Model;
using Sales.Model.Domain;

namespace Sales.DBContext
{
    public class SalesDBContext : DbContext
    {
        public SalesDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserToRole> UserToRoles { get; set; }
        public DbSet<RoleToPermission> RoleToPermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        

    }


}



