
using Sales.Enum;
using Sales.Model.Domain;
using System.ComponentModel.DataAnnotations;

namespace Sales.Model
{
    public class Permission
    {
        public Guid Id { get; set; }

        public string PermissionName { get; set; } = null!;

        public string Description { get; set; } = null!;

        public Status Pemissionstatus { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual RoleToPermission? RoleToPermission { get; set; }
    }
}
