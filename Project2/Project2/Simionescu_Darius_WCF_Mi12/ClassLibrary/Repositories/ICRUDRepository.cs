using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibApi.Repositories {
    interface ICRUDRepository<Object> {
        IEnumerable<Object> getAll();
        Object GetObjectById(int id);
        Object InsertObject(Object obj);
        void DeleteObject(int id);
        void UpdateObject(Object obj);
        void SaveChanges();
    }
}
