using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleRegistrationBE.Entities
{
    [Serializable]
    [Table("MS_Storage_Location")]
    public class MsStorageLocationEntity : BaseEntity
    {
        [Column(name: "location_id")]
        [MaxLength(10)]
        [Key]
        public string LocationId { get; set; }

        [Column(name: "location_name")]
        [MaxLength(100)]
        public string LocationName { get; set; }
    }
}
