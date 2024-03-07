using System;
using System.Net.Http.Headers;
using System.Threading.Channels;

namespace BurcBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Elimde veri olarak bir ay ve bir gün var
            // Çıktı olarak girilen verilere göre burç hesaplanacak

            Console.WriteLine("Lütfen doğum tarihinizin gününü giriniz :  ");
            int gun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen doğum ayınızı sayı olarak giriniz :  ");
            int ay = Convert.ToInt32(Console.ReadLine());


            string burc = HangiBurc(ay, gun);
            Console.WriteLine($"Doğum tarihinize göre burcunuz : {burc} burcudur...  ");



            Console.ReadKey();
        }


        #region Methods
        // bütün iş burada dönecek
        static string HangiBurc(int ay, int gun)
        {
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
                return "Koç";
            else if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 21))
                return "Boğa";
            else if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 21))
                return "İkizler";
            else if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22))
                return "Yengeç";
            else if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
                return "Aslan";
            else if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
                return "Başak";
            else if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
                return "Terazi";
            else if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21))
                return "Akrep";
            else if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
                return "Yay";
            else if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 20))
                return "Oğlak";
            else if ((ay == 1 && gun >= 21) || (ay == 2 && gun <= 18))
                return "Kova";
            else if ((ay == 2 && gun >= 19) || (ay == 3 && gun <= 20))
                return "Balık";
            else
                return "Geçersiz Tarih girdiniz...";


        }
        
       

    #endregion

    }

}