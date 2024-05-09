using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleRegistrationBE.Entities
{
    [Serializable]
    [Table("MS_User")]

    public class MsUserEntity : BaseEntity
    {
        [Column(name: "user_id")]
        [Key]
        public int Id { get; set; }

        [Column(name: "user_name")]
        [MaxLength(20)]
        public string Username { get; set; }

        [Column(name: "password")]
        [MaxLength(50)]
        public string Password { get; set; }

        [Column(name: "is_active")]
        public bool IsActive { get; set; } = true;
    }
}
