internal class Program
{
    private static void Main(string[] args)
    {
        ///Stack ve Heap Kavramları
        ///Value Type ve Reference Type Kavramları
        ///Garbage Collector (Çöp Toplama) Mekanizması
        ///
        int sayi1 = 10; //Stack'te saklanır
        int sayi2 = sayi1; //sayi1'in değeri sayi2'ye kopyalanır
        sayi2 = 20; //sayi2'nin değeri değiştirilir, sayi1 etkilenmez
        Console.WriteLine(sayi1);
    }
}