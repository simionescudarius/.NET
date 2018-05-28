using BibApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2.Transformers {
    class ImprumutTransformer {
        public static ImprumutDTO fromModelToDto(Imprumut model) {
            if (model == null) {
                return null;
            }
            ImprumutDTO imprumutDto = new ImprumutDTO();
            imprumutDto.imprumutId = model.imprumutId;
            imprumutDto.carteId = model.carteId;
            imprumutDto.cititorId = model.cititorId;
            imprumutDto.dataImprumut = model.dataImprumut;
            imprumutDto.dataImprumut = model.dataImprumut;
            imprumutDto.dataImprumut = model.dataImprumut;

            return imprumutDto;
        }

        public static Imprumut fromDtoToModel(ImprumutDTO dto) {
            Imprumut imprumut = new Imprumut();
            imprumut.imprumutId = dto.imprumutId;
            imprumut.carteId = dto.carteId;
            imprumut.cititorId = dto.cititorId;
            imprumut.dataImprumut = dto.dataImprumut;
            imprumut.dataImprumut = dto.dataImprumut;
            imprumut.dataImprumut = dto.dataImprumut;

            return imprumut;
        }

        public static List<ImprumutDTO> fromModelListToDtoList(List<Imprumut> modelList) {
            List<ImprumutDTO> dtoList = new List<ImprumutDTO>();
            foreach(Imprumut model in modelList){
                dtoList.Add(fromModelToDto(model));
            }

            return dtoList;
        }
    }
}
