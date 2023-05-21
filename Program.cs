namespace C__PATİKA;
class Program
{
    static void Main(string[] args)
    {   
        int derinlik;
        Back:
        System.Console.Write("Program tarafindan verilen derinliğe göre fibonacci serisinin ortalama hesabı yapılmaktadır.\nLütfen bir derinlik giriniz : ");
        if ((!Int32.TryParse(Console.ReadLine(), out derinlik)) || (derinlik<1))
        {
            System.Console.WriteLine("Hatali giriş! Girilen değer pozitif ve sadece rakamdan oluşmalidir...");
            goto Back;
        }
        
        decimal ortalama = Methods.OrtalamaFibonacci(derinlik);

        System.Console.WriteLine();
        System.Console.Write($"Fibonacci Series :");

        foreach (var item in Methods.FibSeries)
        {
            System.Console.Write(" "+item);
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Fibonacci serisinin derinliğe göre ortalaması : {ortalama}");
    }
}

public class Methods
{
    public static List<int> FibSeries = new List<int>();
    public static int FibonacciSeries(int derinlik)
    {
        int sayac=1;
        int a = 0;
        int b =1;
        int toplam=0;
        int geneltoplam=0;
        FibSeries.Add(b);
        geneltoplam = a+b;
        while(sayac<=derinlik-1){
            toplam = a + b;
            FibSeries.Add(toplam);
            geneltoplam +=toplam; 
            a=b;
            b=toplam;
            sayac++;
        }
        return geneltoplam;
    }

    public static decimal OrtalamaFibonacci(int derinlik)
    {
        int toplam = FibonacciSeries(derinlik);
        decimal ortalama = ((decimal)toplam/(decimal)derinlik);
        return ortalama;
    }
}
