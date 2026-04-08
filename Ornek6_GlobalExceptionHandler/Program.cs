using Ornek6_GlobalExceptionHandler;
internal class Program
{
    private static void Main(string[] args)
    {

		//AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
		//{
		//	Exception ex = (Exception)e.ExceptionObject;
		//	GlobalExceptionHandler.HandleException(ex);
		//};

		AppDomain.CurrentDomain.UnhandledException += IstisnaFırlatılmaOlayıGerceklesti;

		int a = 10;
		int b = 0;
		int sonuc = a / b; // Bu satır hata verecektir çünkü sıfıra bölme hatası oluşur

        throw new Exception("Bu bir test istisnasıdır."); // Global exception handler tarafından yakalanacak bir istisna fırlatılır
                                                          //      try
                                                          //{
                                                          //	int a = 10;
                                                          //	int b = 0;
                                                          //	int sonuc = a / b;
                                                          //      }
                                                          //catch (Exception e)
                                                          //{
                                                          //          GlobalExceptionHandler.HandleException(e);
                                                          //}
    }

	static void IstisnaFırlatılmaOlayıGerceklesti(object sender, UnhandledExceptionEventArgs e)
	{
		Exception ex = (Exception)e.ExceptionObject;
		GlobalExceptionHandler.HandleException(ex);
    }


    ///Global exception handler, uygulama genelinde meydana gelen istisnaları yakalayarak 
    ///merkezi bir şekilde yönetmeyi sağlar. Bu sayede, uygulamanın herhangi bir yerinde meydana gelen hatalar tek bir noktada ele alınabilir ve uygun şekilde loglanabilir veya kullanıcıya gösterilebilir. Global exception handler, uygulamanın kararlılığını artırır 
    ///ve hataların daha etkili bir şekilde yönetilmesine olanak tanır.
    ///Global şekilde hataları yakalamak için AppDomain.CurrentDomain sınıfında bulunan
    ///UnhandledException olayına bir event handler eklenir. 
    ///Bu event handler, uygulama genelinde meydana gelen istisnaları yakalayarak 
    ///GlobalExceptionHandler sınıfında tanımlanan HandleException metodunu çağırır. 
    ///Böylece, uygulamanın herhangi bir yerinde meydana gelen hatalar tek bir noktada ele alınabilir 
    ///ve uygun şekilde loglanabilir veya kullanıcıya gösterilebilir.
}