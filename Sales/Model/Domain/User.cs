using Sales.Enum;
using System.ComponentModel.DataAnnotations;

namespace Sales.Model.Domain
{
    public class User
    {
        public Guid UserId { get; set; }

        public Guid EmployeeId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public Status UserStatus { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual UserToRole? UserToRole { get; set; }

    }
}
