using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCF_Project2 {
    [DataContract]
    public class GenDTO{

        [DataMember]
        public int genId { get; set; }

        [DataMember]
        public string descriere { get; set; }

        [DataMember]
        public List<CarteDTO> CarteDto { get; set; }

        public GenDTO() {
        }
    }
}
