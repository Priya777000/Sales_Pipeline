using Sales.Enum;

namespace Sales.Model.Domain
{
    public class RoleToPermission
    {
        public Guid Id { get; set; }

        public Guid PermissionId { get; set; }

        public Guid RoleId { get; set; }

        public Status RoleToUserStatus { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual Role Id1 { get; set; } = null!;

        public virtual Permission IdNavigation { get; set; } = null!;

    }
}
