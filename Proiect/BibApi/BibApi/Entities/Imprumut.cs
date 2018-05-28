namespace BibApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Imprumut")]
    public partial class Imprumut
    {
        public Imprumut()
        {
            Review = new HashSet<Review>();
        }

        public int imprumutId { get; set; }

        public int carteId { get; set; }

        public int cititorId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dataImprumut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dataScadenta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dataRestituire { get; set; }

        public virtual Carte Carte { get; set; }

        public virtual Cititor Cititor { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}
