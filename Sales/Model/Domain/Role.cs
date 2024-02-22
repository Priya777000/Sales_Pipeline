using Sales.Enum;
using System.ComponentModel.DataAnnotations;

namespace Sales.Model.Domain
{
    public class Role
    {

        public Guid Id { get; set; }

        public string RoleName { get; set; } = null!;

        public string Description { get; set; } = null!;

        public Status RoleStatus { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual RoleToPermission? RoleToPermission { get; set; }

        public virtual ICollection<UserToRole> UserToRoles { get; set; } = new List<UserToRole>();
    }
}
