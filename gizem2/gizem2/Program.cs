

using System;

class Program
{

    static void Main(string[] args)
    {
        int aracTipi = 0;
        bool result = true;
        double odenecekTutar = 0;
        double kalinanSure = 0;
        



        Console.WriteLine("1. Otomobil için 1'e basın \n" +
        "2. Motosiklet için 2'ye basın\n" +
        "3. Minibüs için 3'e basın\n" +
        "4. Kamyon (ve diğer ticari araçlar) için 4'e basın\n");

        if (int.TryParse(Console.ReadLine(), out aracTipi))
        {
            Console.Write("Kalınan Süreyi Giriniz : ");
            kalinanSure = Convert.ToDouble(Console.ReadLine());

            if (kalinanSure >= 0 && kalinanSure <= 2)
            {
                for (double i = 0; i <= kalinanSure; i += 0.1)
                {
                    if (i == 0)
                    {
                        if (aracTipi == 1)
                        {
                            odenecekTutar = 5;
                        }
                        else if (aracTipi == 2)
                        {
                            odenecekTutar = 0;
                        }
                        else if (aracTipi == 3)
                        {
                            odenecekTutar = 8;
                        }
                        else if (aracTipi == 4)
                        {
                            odenecekTutar = 15;
                        }
                    }
                }
            }
            else if (kalinanSure > 2 && kalinanSure <= 6)
            {
                for (double i = 2.1; i < kalinanSure; i += 0.1)
                {
                    if (i == 2.1)
                    {
                        if (aracTipi == 1)
                        {
                            odenecekTutar = 10;
                        }
                        else if (aracTipi == 2)
                        {
                            odenecekTutar = 6;
                        }
                        else if (aracTipi == 3)
                        {
                            odenecekTutar = 16;
                        }
                        else if (aracTipi == 4)
                        {
                            odenecekTutar = 30;
                        }
                    }
                }
            }
            else if (kalinanSure > 6 && kalinanSure <= 12)
            {
                for (double i = 6.1; i < kalinanSure; i += 0.1)
                {
                    if (i == 6.1)
                    {
                        if (aracTipi == 1)
                        {
                            odenecekTutar = 20;
                        }
                        else if (aracTipi == 2)
                        {
                            odenecekTutar = 12;
                        }
                        else if (aracTipi == 3)
                        {
                            odenecekTutar = 32;
                        }
                        else if (aracTipi == 4)
                        {
                            odenecekTutar = 60;
                        }
                    }
                }
            }
            else if (kalinanSure > 12 && kalinanSure <= 24)
            {
                for (double i = 12.1; i < kalinanSure; i += 0.1)
                {
                    if (i == 12.1)
                    {
                        if (aracTipi == 1)
                        {
                            odenecekTutar = 35;
                        }
                        else if (aracTipi == 2)
                        {
                            odenecekTutar = 20;
                        }
                        else if (aracTipi == 3)
                        {
                            odenecekTutar = 45;
                        }
                        else if (aracTipi == 4)
                        {
                            odenecekTutar = 100;
                        }
                    }
                }
            }
            else
            {
                for (double i = 24.1; i < kalinanSure; i += 0.1)
                {
                    double gun = kalinanSure / 24;
                    double gunTamSayi = Math.Truncate(gun);
                    if (i == 24.1)
                    {
                     
                            if (aracTipi == 1)
                            {
                                odenecekTutar = (gunTamSayi * 20)+ 55;
                            }
                            else if (aracTipi == 2)
                            {
                                odenecekTutar = (gunTamSayi * 10)+30;
                            }
                            else if (aracTipi == 3)
                            {
                                odenecekTutar =(gunTamSayi * 25)+70;
                            }
                            else if (aracTipi == 4)
                            {
                                odenecekTutar =(gunTamSayi * 55)+155;
                            }
                        
                    }
                }
            }



        }

        Console.WriteLine("Ödenecek Tutar : {0} TL", odenecekTutar );
        

        






    }
    

}
