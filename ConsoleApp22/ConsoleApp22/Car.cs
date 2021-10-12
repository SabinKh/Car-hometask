using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    class Car
    {
        public double IsledilenBenzin { get; set; } 
        public double BakTutumu = 150;
        public double Bakdaolanbenzin { get; set; }
        public double Kilometr { get; set; }
        public double QalanBenzin { get; set; }
        public double Yuzkmyabenzin = 10;
        

        

        public Car(double km)
        {
            Bakdaolanbenzin = 100;
            Kilometr = km;
        }

        public void Drive()
        {
            double kmyadusenbenzin = Yuzkmyabenzin / 100;
            if (Bakdaolanbenzin >= (Kilometr * kmyadusenbenzin))
            {
                IsledilenBenzin = (Kilometr * kmyadusenbenzin);
                QalanBenzin = Bakdaolanbenzin - (Kilometr * kmyadusenbenzin);

                Console.WriteLine($"isledilen benzin:{IsledilenBenzin}");
                Console.WriteLine($"qalan benzin:{QalanBenzin}");
            }
            else if(Bakdaolanbenzin < (Kilometr * kmyadusenbenzin))
            {
                BenzinDoldur(100);// doldurulacaq benzin
                Money(500);  //cibinde olan pul
                
            }
            

        }

        public void BenzinDoldur(double doldurulacaqbenzin)
        {
            if (doldurulacaqbenzin>BakTutumu)
            {
                Console.WriteLine("Benzin dasacaq");
            }
            else if (doldurulacaqbenzin<=BakTutumu)
            {
                Console.WriteLine("Bak tam dolub,sure bilersiz");
            }
        }
        public void Money(double n)
        {
            double qalanpul;

            //1l=2man
            double benzininqiymet = Kilometr * (Yuzkmyabenzin / 100)*2;
            if (n<benzininqiymet)
            {
                Console.WriteLine("pulun catmir");
            }
            else
            {
                Console.WriteLine($"Benzin ucun lazim olan pul:{benzininqiymet}");
                qalanpul = n - benzininqiymet;
                Console.WriteLine($"Qalanpul: {qalanpul}");
            }

            
           
                   
            
            
        }
            

         
    }
}
