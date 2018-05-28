using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCF_Project2 {
    [DataContract]
    public class CititorDTO{
        [DataMember]
        public int cititorId { get; set; }

        [DataMember]
        public string nume { get; set; }

        [DataMember]
        public string prenume { get; set; }

        [DataMember]
        public string adresa { get; set; }

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public short? stare { get; set; }

        [DataMember]
        public List<ImprumutDTO> ImprumutDto { get; set; }

        public CititorDTO() {
        }
    }
}
