using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleRegistrationBE.Entities
{
    [Serializable]
    public class BaseEntity
    {
        [Column(name: "created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column(name: "created_by")]
        public string? CreatedBy { get; set; }

        [Column(name: "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column(name: "updated_by")]
        public string? UpdatedBy { get; set; }

        [Column(name: "deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [Column(name: "deleted_by")]
        public string? DeletedBy { get; set; }
    }
}
