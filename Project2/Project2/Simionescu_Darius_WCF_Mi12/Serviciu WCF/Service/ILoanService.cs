using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2 {
    [ServiceContract]
    public interface ILoanService {
        [OperationContract]
        void LoanBook(CarteDTO book, CititorDTO reader, DateTime loanDate, DateTime deadLine);

        [OperationContract]
        void UpdateLoan(ImprumutDTO imprumut);

        [OperationContract]
        ImprumutDTO GetLoanByUserEmail(string email);

        [OperationContract]
        ImprumutDTO GetLoanByUserId(int id);

        [OperationContract]
        ImprumutDTO GetLoanForBookId(int bookId);
    }
}
