using BibApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2.Transformers {
    class CarteTransformer {
        public static CarteDTO fromModelToDto(Carte model) {
            if (model == null) {
                return null;
            }
            CarteDTO carteDto = new CarteDTO();
            carteDto.carteId = model.carteId;
            carteDto.autorId = model.autorId;
            carteDto.genId = model.genId;
            carteDto.titlu = model.titlu;
            carteDto.AutorDto = AutorTransformer.fromModelToDto(model.Autor);
            carteDto.GenDto = GenTransformer.fromModelToDto(model.Gen);
            return carteDto;
        }

        public static Carte fromDtoToModel(CarteDTO dto) {
            Carte carte = new Carte();
            carte.carteId = dto.carteId;
            carte.autorId = dto.autorId;
            carte.genId = dto.genId;
            carte.titlu = dto.titlu;

            return carte;
        }

        public static List<CarteDTO> fromModelListToCarteDtoList(List<Carte> modelList) {
            List<CarteDTO> dtos = new List<CarteDTO>();
            foreach (Carte carte in modelList) {
                dtos.Add(fromModelToDto(carte));
            }

            return dtos;
        }
    }
}
