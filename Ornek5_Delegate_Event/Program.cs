internal class Program
{
    delegate void temsilci();
    static void Selamlama()
    {
        Console.WriteLine("Merhaba, Dünya!");
    }   
    
    static void Yazdir() 
    {         
        Console.WriteLine("Bu bir delegate örneğidir.");
    }
    private static void Main(string[] args)
    {
        temsilci a;
        a = Selamlama;
        a();

        a = Yazdir;
        a();


    }
}