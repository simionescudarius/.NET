namespace BibApi
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Autor")]
    public partial class Autor
    {
        public Autor()
        {
            Carte = new HashSet<Carte>();
        }

        public int autorId { get; set; }

        [StringLength(20)]
        public string nume { get; set; }

        [StringLength(20)]
        public string prenume { get; set; }

        public virtual ICollection<Carte> Carte { get; set; }
    }
}
