using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCF_Project2 {
    [DataContract]
    public class CarteDTO{
        [DataMember]
        public int carteId { get; set; }

        [DataMember]
        public int autorId { get; set; }

        [DataMember]
        public int genId { get; set; }

        [DataMember]
        public string titlu { get; set; }

        [DataMember]
        public AutorDTO AutorDto { get; set; }

        [DataMember]
        public GenDTO GenDto { get; set; }

        [DataMember]
        public List<ImprumutDTO> ImprumutDto { get; set; }

        public CarteDTO() {
        }
    }
}
