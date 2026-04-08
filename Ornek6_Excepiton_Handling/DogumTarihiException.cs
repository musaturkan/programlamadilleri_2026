using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6_Excepiton_Handling
{
    public class DogumTarihiException : Exception
    {

        //public DogumTarihiException()
        //{
        //}
        public DogumTarihiException(string message) : base(message)
        {
        }
        //public DogumTarihiException(string message, Exception innerException) : base(message, innerException)
        //{
        //}
    }
}
