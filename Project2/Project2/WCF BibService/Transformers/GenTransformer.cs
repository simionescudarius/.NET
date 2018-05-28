using BibApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2.Transformers {
    class GenTransformer {
        public static GenDTO fromModelToDto(Gen model) {
            if (model == null) {
                return null;
            }
            GenDTO genDto = new GenDTO();
            genDto.genId = model.genId;
            genDto.descriere = model.descriere;

            return genDto;
        }

        public static Gen fromDtoToModel(GenDTO dto) {
            Gen gen = new Gen();
            gen.genId = dto.genId;
            gen.descriere = dto.descriere;

            return gen;
        }
    }
}
