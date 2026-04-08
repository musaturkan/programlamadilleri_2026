using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_4_Library_Generic_Kavrami
{
    /// <summary>
    /// Wehere ile kısıt tanımlanabilir. T tipi IBaseEntity arayüzünden türemiş bir sınıf olmak zorundadır.
    /// T tipinin bir sınıf olaması,new() ile parametsesiz yapıcı metotu olması gerekir diyebiliriz
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataService<T> where T : IBaseEntity, new()
    {
        private List<T> data = new List<T>();

        public void Add(T eleman)
        {
            data.Add(eleman);
        }

        public List<T> Listele()
        {
            return data;
        }
    }
}
