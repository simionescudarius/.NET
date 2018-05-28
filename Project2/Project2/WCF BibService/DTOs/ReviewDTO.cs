using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCF_Project2 {
    [DataContract]
    public partial class ReviewDTO{
        [DataMember]
        public int reviewId { get; set; }

        [DataMember]
        public int imprumutId { get; set; }

        [DataMember]
        public string text { get; set; }

        [DataMember]
        public ImprumutDTO ImprumutDto { get; set; }

        public ReviewDTO() {
        }
    }
}
