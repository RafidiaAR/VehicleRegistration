using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleRegistrationBE.Entities
{
    [Serializable]
    [Table("TR_BPKB")]
    public class TrBPKB : BaseEntity
    {
        [Column(name: "agreement_number")]
        [MaxLength(100)]
        [Key]
        public string AgreementNumber { get; set; }

        [Column(name: "bpkb_no")]
        [MaxLength(100)]
        public string BPKBNo { get; set; }

        [Column(name: "branch_id")]
        [MaxLength(10)]
        public string BranchId { get; set; }

        [Column(name: "bpkb_date")]
        public DateTime BPKBDate { get; set; }

        [Column(name: "faktur_no")]
        [MaxLength(100)]
        public string FakturNo { get; set; }

        [Column(name: "faktur_date")]
        public DateTime FakturDate { get; set; }

        [Column(name: "location_id")]
        [MaxLength(10)]
        public string LocationId { get; set; }

        [Column(name: "police_no")]
        [MaxLength(20)]
        public string PoliceNo { get; set; }

        [Column(name: "bpkb_date_in")]
        public DateTime BPKBDateIn { get; set; }
    }
}
