using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Project2 {
    [ServiceContract]
    public interface IReaderService {
        [OperationContract]
        CititorDTO GetReaderByEmail(string email);

        [OperationContract]
        void RegisterReader(CititorDTO cititor);

        [OperationContract]
        bool IsReaderTrustworthy(CititorDTO cititor);
    }
}
