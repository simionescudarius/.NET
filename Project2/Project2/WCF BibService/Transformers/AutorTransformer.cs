using BibApi;

namespace WCF_Project2.Transformers {
    class AutorTransformer {
        public static AutorDTO fromModelToDto(Autor model) {
            if (model == null) {
                return null;
            }
            AutorDTO autorDto = new AutorDTO();
            autorDto.autorId = model.autorId;
            autorDto.nume = model.nume;
            autorDto.prenume = model.prenume;

            return autorDto;
        }

        public static Autor fromDtoToModel(AutorDTO dto) {
            Autor autor = new Autor();
            autor.autorId = dto.autorId;
            autor.nume = dto.nume;
            autor.prenume = dto.prenume;

            return autor;
        }
    }
}