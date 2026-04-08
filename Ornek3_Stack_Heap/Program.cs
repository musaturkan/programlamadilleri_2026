namespace Ornek3_Stack_Heap;

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

        Arac araba1 = new Arac();
        //Heap'te saklanır, araba1 referansını tutar
        araba1.Id = 1;
        araba1.Ad = "Model S";
        araba1.Marka = "Tesla";

        Arac araba2 = new Arac();
        //Heap'te saklanır, araba2 referansını tutar
        araba2.Id = 2;
        araba2.Ad = "Mustang";
        araba2.Marka = "Ford";

        araba2 = araba1; //araba2 artık araba1'in referansını tutar, eski araba2 nesnesi çöpe atılır

        araba2.Ad = "T10X";
        araba2.Marka = "TOGG";

        Console.WriteLine(araba1.Ad);
    }
}