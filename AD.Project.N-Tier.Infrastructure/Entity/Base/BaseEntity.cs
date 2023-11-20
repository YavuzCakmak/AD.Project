using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AD.Project.N_Tier.Infrastructure.Entity.Base
{
    public abstract class BaseEntity
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }

        [Column("Is_Deleted")]
        public bool IsDeleted { get; set; }
    }
}
