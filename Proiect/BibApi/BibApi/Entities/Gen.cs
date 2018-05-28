namespace BibApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gen")]
    public partial class Gen
    {
        public Gen()
        {
            Carte = new HashSet<Carte>();
        }

        public int genId { get; set; }

        [StringLength(50)]
        public string descriere { get; set; }

        public virtual ICollection<Carte> Carte { get; set; }
    }
}
