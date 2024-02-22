using Sales.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Model.Domain
{
    public class UserToRole
    {

        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public Status UserToRoleStatus { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual User IdNavigation { get; set; } = null!;

        public virtual Role Role { get; set; } = null!;

    }
}
