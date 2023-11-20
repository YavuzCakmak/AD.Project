using AD.Project.N_Tier.Infrastructure.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AD.Project.N_Tier.Infrastructure.Entity.User
{
    public class UserEntity : BaseEntity
    {
        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("NumberOfIncorrectEntries")]
        public int NumberOfIncorrectEntries { get; set; }

        [Column("BirthDate")]
        public DateTime BirthDate { get; set; }
    }
}
