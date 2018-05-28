using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCF_Project2 {
    [DataContract]
    public class AutorDTO{
        [DataMember]
        public int autorId { get; set; }

        [DataMember]
        public string nume { get; set; }

        [DataMember]
        public string prenume { get; set; }

        [DataMember]
        public List<CarteDTO> CarteDto { get; set; }

        public AutorDTO() {
        }
    }
}