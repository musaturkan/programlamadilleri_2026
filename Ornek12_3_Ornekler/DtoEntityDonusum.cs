using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_3_Ornekler
{
    public class DtoEntityDonusum
    {
        public EntityTipi DtoEntityYap<DtoTipi,EntityTipi>(DtoTipi nesne) where DtoTipi : class, new() 
                                                             where EntityTipi : class, new()
        {
            EntityTipi entity = new EntityTipi();
            ///Burada entity ile dto nesnesi arasında dönüşüm işlemi yapılır.
            var entiyOzellikListesi = entity.GetType().GetProperties().ToList();
            foreach (var ozellik in entiyOzellikListesi)
            {
                var dtoKarsilikOzelligi = nesne.GetType().GetProperty(ozellik.Name);
                if (dtoKarsilikOzelligi != null)
                {
                    var value = dtoKarsilikOzelligi.GetValue(nesne);
                    ozellik.SetValue(entity, value);
                }

            }           

            return entity;
        }

        public DtoTipi EntityDtoYap<EntityTipi, DtoTipi>(EntityTipi nesne) where EntityTipi : class, new()
                                                             where DtoTipi : class, new()
        {
            DtoTipi dto = new DtoTipi();
            ///Burada entity ile dto nesnesi arasında dönüşüm işlemi yapılır.
            return dto;
        }
    }
