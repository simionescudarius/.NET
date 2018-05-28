using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2 {
    [ServiceContract]
    public interface IBookService {
        [OperationContract]
        void BuyBooks(CarteDTO carteDto, short numberOfBooks);

        [OperationContract]
        List<CarteDTO> GetAvailableBooks();

        [OperationContract]
        CarteDTO GetBookById(int id);

        [OperationContract]
        List<CarteDTO> GetAllBooks();

        [OperationContract]
        List<CarteDTO> GetBooksByGen(string gen);
    }
}
