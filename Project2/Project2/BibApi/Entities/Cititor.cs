namespace BibApi
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Cititor")]
    public partial class Cititor
    {
        public Cititor()
        {
            Imprumut = new HashSet<Imprumut>();
        }

        public int cititorId { get; set; }

        [Required]
        [StringLength(15)]
        public string nume { get; set; }

        [StringLength(50)]
        public string prenume { get; set; }

        [StringLength(50)]
        public string adresa { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public short? stare { get; set; }

        public virtual ICollection<Imprumut> Imprumut { get; set; }
    }
}
