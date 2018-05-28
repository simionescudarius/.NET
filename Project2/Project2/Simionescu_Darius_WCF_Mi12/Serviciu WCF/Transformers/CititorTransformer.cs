using BibApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2.Transformers {
    class CititorTransformer {
        public static CititorDTO fromModelToDto(Cititor model) {
            if (model == null) {
                return null;
            }
            CititorDTO cititorDto = new CititorDTO();
            cititorDto.cititorId = model.cititorId;
            cititorDto.nume = model.nume;
            cititorDto.prenume = model.prenume;
            cititorDto.adresa = model.adresa;
            cititorDto.email = model.email;
            cititorDto.stare = model.stare;

            return cititorDto;
        }

        public static Cititor fromDtoToModel(CititorDTO dto) {
            Cititor cititor = new Cititor();
            cititor.cititorId = dto.cititorId;
            cititor.nume = dto.nume;
            cititor.prenume = dto.prenume;
            cititor.adresa = dto.adresa;
            cititor.email = dto.email;
            cititor.stare = dto.stare;

            return cititor;
        }
    }
}
