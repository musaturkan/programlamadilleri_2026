using DataModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_4_Library_Generic_Kavrami.GenericDataModel
{
    public class DataModelService<T> where T : class, new()
    {  
        MarketContext model = new MarketContext();
        public void AddEntity(T entity)
        {   
            model.Set<T>().Add(entity);
            model.SaveChanges();
            ///veri tabanına entity ekleme işlemi
        }

        public void RemoveEntity(T entity) { }
        public T GetEntity(int id) { 
         model.Set<T>().Find(id);
            return new T();
        }

        public IEnumerable<T> GetAllEntities() { 
            var liste  = model.Set<T>().ToList();
        
            //model.Kullanici.ToList();

            return liste;
        }



   

        


    }
}
