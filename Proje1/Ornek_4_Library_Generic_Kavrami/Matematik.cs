using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_4_Library_Generic_Kavrami
{
    public class Matematik
    {
        //public int Topla(int a, int b)
        //{
        //    return a + b;
        //}

        //public double Topla(double a, double b)
        //{
        //    return a + b;
        //}

        //public string Topla(string a, string b)
        //{
        //    return a + b;
        //}

        ///Bir kod tekrar tekrar yazılmak zorunda kalınıyorsa, 
        ///o kodun genelleştirilmesi ve tek bir yerde yazılması daha iyi olur. 
        ///Bu şekilde kodun bakımı ve okunabilirliği artar.
        ///Topla metodunu generic hale getirelim
        
        public T Topla<T>(T a, T b)
        {
            //return a + b;
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
    }
}
