using System.ComponentModel.DataAnnotations;

namespace KonyvlistaWebApp.Models
{
    public class Konyv
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A cím megadása kötelező!")]
        [StringLength(100, ErrorMessage = "A cím maximum 100 karakter hosszú lehet")]
        public string Cim { get; set; }

        [Required(ErrorMessage = "A szerző megadása kötelező!")]
        [StringLength(80, ErrorMessage = "A cím maximum 80 karakter hosszú lehet")]
        public string Szerzo { get; set; }

        [Display(Name = "Kiadás éve")]
        public int KiadasEve { get; set; }

        [Display(Name = "Ár")]
        public decimal Ar { get; set; }

    }
}

