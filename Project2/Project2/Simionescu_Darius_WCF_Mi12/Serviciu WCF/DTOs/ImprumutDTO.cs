using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCF_Project2 {
    [DataContract]
    public class ImprumutDTO{
        [DataMember]
        public int imprumutId { get; set; }

        [DataMember]
        public int carteId { get; set; }

        [DataMember]
        public int cititorId { get; set; }

        [DataMember]
        public DateTime? dataImprumut { get; set; }

        [DataMember]
        public DateTime? dataScadenta { get; set; }

        [DataMember]
        public DateTime? dataRestituire { get; set; }

        [DataMember]
        public CarteDTO CarteDto { get; set; }

        [DataMember]
        public CititorDTO CititorDto { get; set; }

        [DataMember]
        public List<ReviewDTO> Review { get; set; }

        public ImprumutDTO() {
        }
    }
}
