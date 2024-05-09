using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace VehicleRegistrationFE.Models
{
    public class CreateDocumentViewModel
    {
        [Required]
        public string AgreementNumber { get; set; }

        [Required]
        public string BranchID { get; set; }

        [Required]
        public string NoBPKB { get; set; }

        [Required]
        [Display(Name = "Tanggal BPKB In")]
        public DateTime TanggalBPKBIn { get; set; }

        [Required]
        [Display(Name = "Tanggal BPKB")]
        public DateTime TanggalBPKB { get; set; }

        [Required]
        public string NoFaktur { get; set; }

        [Required]
        [Display(Name = "Tanggal Faktur")]
        public DateTime TanggalFaktur { get; set; }

        [Required]
        [Display(Name = "No Polisi")]
        public string NoPolisi { get; set; }

        [Required]
        [Display(Name = "Lokasi Penyimpanan")]
        public string LokasiPenyimpanan { get; set; }

        public List<SelectListItem> LokasiPenyimpananList { get; set; }
    }
}
