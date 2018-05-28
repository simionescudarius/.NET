namespace BibApi
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Review")]
    public partial class Review
    {
        public int reviewId { get; set; }

        public int imprumutId { get; set; }

        [StringLength(4096)]
        public string text { get; set; }

        public virtual Imprumut Imprumut { get; set; }
    }
}
