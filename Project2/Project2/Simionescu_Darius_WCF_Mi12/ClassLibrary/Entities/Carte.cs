namespace BibApi
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Carte")]
    public partial class Carte
    {
        public Carte()
        {
            Imprumut = new HashSet<Imprumut>();
        }

        public int carteId { get; set; }

        public int autorId { get; set; }

        public int genId { get; set; }

        [StringLength(50)]
        public string titlu { get; set; }

        public virtual Autor Autor { get; set; }

        public virtual Gen Gen { get; set; }

        public virtual ICollection<Imprumut> Imprumut { get; set; }
    }
}
