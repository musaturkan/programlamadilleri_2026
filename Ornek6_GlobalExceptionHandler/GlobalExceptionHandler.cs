using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6_GlobalExceptionHandler
{
    public static class GlobalExceptionHandler
    {
        public static void HandleException(Exception ex)
        {
            // Hata bilgilerini loglama veya kullanıcıya gösterme işlemleri burada yapılabilir
            Console.WriteLine("Global Exception Handler: " + ex.Message);
            LogException(ex);
        }

        public static void LogException(Exception ex)
        {
            // Hata bilgilerini loglama işlemleri burada yapılabilir
            Console.WriteLine("Hata Loglandı: " + ex.Message);
            System.IO.File.AppendAllText("error_log.txt", DateTime.Now.ToString() + " - " + ex.Message + Environment.NewLine);
        }
    }
}
