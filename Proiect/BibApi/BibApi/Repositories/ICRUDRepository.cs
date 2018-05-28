using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibApi.Repositories {
    interface ICRUDRepository<Object> {
        IEnumerable<Object> getAll();
        Object getObjectById(int id);
        Object insertObject(Object obj);
        void deleteObject(int id);
        void updateObject(Object obj);
        void saveChanges();
    }
}
