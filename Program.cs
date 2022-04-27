using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhammed_Sağlam_201713709005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muhammed_Sağlam_201713709005
            string[][] ogrenci = new string[3][];
            ogrenci[0] = new string[5];
            ogrenci[1] = new string[5];
            ogrenci[2] = new string[5];
            string[][] ders = new string[2][];
            ders[0] = new string[3];
            ders[1] = new string[3];
            int[][] not = new int[3][];
            not[0] = new int[10];
            not[1] = new int[10];
            not[2] = new int[10];
            int indeks1 = 0, indeks2 = 0;
            int toplam1 = 0, toplam2 = 0, toplam3 = 0, toplam4 = 0, toplam5 = 0;
            int sayac1 = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0, sayac5 = 0;


            char islem;
        bas:
            Console.Clear();
            Console.WriteLine("#### ÖĞRENCİ OTOMASYONU ####");
            Console.WriteLine();
            Console.WriteLine("1.Öğrenci Kaydet");
            Console.WriteLine("2.Öğrencileri Listele");
            Console.WriteLine("3.Ders ekle");
            Console.WriteLine("4.Dersleri Listele");
            Console.WriteLine("5.Not ekle");
            Console.WriteLine("6.Notları listele");
            Console.WriteLine();
            Console.WriteLine("###########################");
            Console.WriteLine();
            Console.WriteLine("7.Öğrenci not ortalaması ");
            Console.WriteLine("8.Tüm öğrencilerin not ortalamaları");
            Console.WriteLine();
            Console.WriteLine("###########################");
            Console.WriteLine();
            Console.WriteLine("0.Çıkış");
            Console.WriteLine();
            Console.Write("Lütfen Seçiminizi Yapınız: ");

            islem = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            switch (islem)
            {
                case '1':
                    Console.WriteLine("#### ÖĞRENCİ GİRİŞİ ####");
                    Console.WriteLine("");
                    Console.WriteLine("Girilecek Öğrenci Sayısı: 5");
                    Console.WriteLine("");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("{0}.Öğrencinin Bilgilerini Giriniz; ", i + 1);
                    hata:
                        Console.Write("Öğrenci No: ", i + 1);
                        ogrenci[0][i] = Console.ReadLine();
                        for (int j = 0; j < i; j++)
                        {
                            if (ogrenci[0][i] == ogrenci[0][j])
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Bu öğrenci numarasına ait bir kayıt mevcuttur. Aynı numara ile birden fazla kayıt yapılamaz. Lütfen başka bir öğrenci numarası giriniz.");
                                Console.WriteLine("");
                                goto hata;
                            }
                        }
                        Console.Write("Öğrenci Adı: ", i + 1);
                        ogrenci[1][i] = Console.ReadLine();
                        Console.Write("Öğrenci Soyadı: ", i + 1);
                        ogrenci[2][i] = Console.ReadLine();
                        Console.WriteLine("");
                    }
                    Console.Write("Veriler eklendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                    Console.ReadLine();
                    goto bas;

                case '2':
                    Console.WriteLine("#### ÖĞRENCİ LİSTESİ ####");
                    Console.WriteLine("");
                    Console.WriteLine("Numara   Ad      Soyad");
                    for (int i = 0; i < 5; i++)
                    {
                        
                        Console.WriteLine("{0}     {1}     {2}", ogrenci[0][i], ogrenci[1][i], ogrenci[2][i]);
                    }
                    Console.WriteLine("");
                    Console.Write("Veriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız. ");
                    Console.ReadLine();
                    goto bas;

                case '3':
                    Console.WriteLine("#### DERS GİRİŞİ ####");
                    Console.WriteLine("");
                    Console.WriteLine("Girilecek ders sayısı: 3");
                    Console.WriteLine("");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("{0}. Dersin bilgilerini giriniz; ", i + 1);
                        Console.WriteLine("");
                    hata:
                        Console.Write("Ders Kodu: ");
                        ders[0][i] = Console.ReadLine();
                        for (int j = 0; j < i; j++)
                        {
                            if (ders[0][i] == ders[0][j])
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Bu ders koduna ait bir kayıt mevcuttur. Aynı numara ile birden fazla kayıt yapılamaz. Lütfen başka bir ders kodu giriniz.");
                                goto hata;
                            }
                        }
                        Console.Write("Ders Adı: ");
                        ders[1][i] = Console.ReadLine();
                    }
                    Console.Write("Veriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız. ");
                    Console.ReadLine();
                    goto bas;

                case '4':
                    Console.WriteLine("#### DERS LİSTESİ ####");
                    Console.WriteLine("");
                    Console.WriteLine("Ders Kodu     Ders Adı   ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("{0}         {1}", ders[0][i], ders[1][i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Veriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                    Console.ReadLine();
                    goto bas;

                case '5':
                    Console.WriteLine("#### NOT GİRİŞİ ####");
                    Console.WriteLine("");
                    Console.WriteLine("Girilecek not sayısı: 10 ");
                    Console.WriteLine("");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("{0}. Notun Bilgilerini Giriniz.", i + 1);
                    hata:
                        Console.Write("Öğrenci No: ");
                        not[0][i] = int.Parse(Console.ReadLine());
                        for (int j = 0; j < 5; j++)
                        {
                            if (ogrenci[0][j] == Convert.ToString(not[0][i]))
                                break;
                            if (ogrenci[0][j] != Convert.ToString(not[0][i]) && j == 4)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Bu öğrenci koduna ait bir kayıt bulunamadı. Lütfen kayıtlı öğrenci kodlarını kullanınız.");
                                Console.WriteLine("");
                                goto hata;
                            }
                        }
                    hata1:

                        Console.Write("Ders Kodunu Giriniz:");
                        not[1][i] = int.Parse(Console.ReadLine());
                        for (int j = 0; j < 3; j++)
                        {
                            if (ders[0][j] == Convert.ToString(not[1][i]))
                                break;
                            if (ders[0][j] != Convert.ToString(not[1][i]) && j == 2)
                            {
                                Console.WriteLine("Bu ders koduna ait bir kayıt bulunamadı. Lütfen kayıtlı ders kodlarını kullanınız. ");
                                Console.WriteLine("");
                                goto hata1;
                            }
                        }
                        Console.Write("Notu Giriniz:");
                        not[2][i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Veriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                    Console.ReadLine();
                    goto bas;

                case '6':
                    Console.WriteLine("#### NOT LİSTESİ ####");
                    Console.WriteLine("");
                    Console.WriteLine("Ad      Soyad    Ders    Not");
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (Convert.ToString(not[0][i]) == ogrenci[0][j])
                                indeks1 = j;
                        }
                        for (int j = 0; j < 3; j++)
                        {
                            if (Convert.ToString(not[1][i]) == ders[0][j])
                                indeks2 = j;
                        }
                        Console.WriteLine("{0}    {1}    {2}         {3}", ogrenci[1][indeks1], ogrenci[2][indeks1], ders[1][indeks2], not[2][i]);
                        indeks1 = 0;
                        indeks2 = 0;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Veriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                    Console.ReadLine();
                    goto bas;

                case '7':
                    Console.WriteLine("#### ÖĞRENCİ NOT ORTALAMASI ####");
                    Console.WriteLine("");
                    Console.Write("Ortalaması bulunacak öğrenci numarasını giriniz: ");
                    Console.WriteLine("");
                    int a = int.Parse(Console.ReadLine());
                    for (int i = 0; i < 10; i++)
                    {
                        if (not[0][i] == a)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (Convert.ToString(not[0][i]) == ogrenci[0][j])
                                    indeks1 = j;
                            }
                            if (Convert.ToString(not[1][i]) == ders[0][0])
                            {
                                toplam1 += not[2][i];
                                sayac1++;
                            }
                            if (Convert.ToString(not[1][i]) == ders[0][1])
                            {
                                toplam2 += not[2][i];
                                sayac2++;
                            }
                            if (Convert.ToString(not[1][i]) == ders[0][2])
                            {
                                toplam3 += not[2][i];
                                sayac3++;
                            }
                        }
                    }
                    if (sayac1 == 0)
                        Console.WriteLine("Ogrencinin {0} dersine ait notu bulunamamıştır", ders[1][0]);
                    else
                        Console.WriteLine("{0} {1} nın {2} dersinde ortalaması: {3}", ogrenci[1][indeks1], ogrenci[2][indeks1], ders[1][0], (float)toplam1 / sayac1);
                    if (sayac2 == 0)
                        Console.WriteLine("Ogrencinin {0} dersine ait notu bulunamamıştır", ders[1][1]);
                    else
                        Console.WriteLine("{0} {1} nın {2} dersinde ortalaması: {3}", ogrenci[1][indeks1], ogrenci[2][indeks1], ders[1][1], (float)toplam2 / sayac2);
                    if (sayac3 == 0)
                        Console.WriteLine("Ogrencinin {0} dersine ait notu bulunamamıştır", ders[1][2]);
                    else
                        Console.WriteLine("{0} {1} nın {2} dersinde ortalaması: {3}", ogrenci[1][indeks1], ogrenci[2][indeks1], ders[1][2], (float)toplam3 / sayac3);
                    toplam1 = 0;
                    toplam2 = 0;
                    toplam3 = 0;
                    sayac1 = 0;
                    sayac2 = 0;
                    sayac3 = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Veriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                    Console.ReadLine();
                    goto bas;
                case '8':
                    Console.WriteLine("#### ÖĞRENCİLERİN NOT ORTALAMALARI ####");
                        Console.WriteLine("");
                    for (int i = 0; i < 10; i++)
                    {
                        if (Convert.ToString(not[0][i]) == ogrenci[0][0])
                        {
                            toplam1 += not[2][i];
                            sayac1++;
                        }
                        if (Convert.ToString(not[0][i]) == ogrenci[0][1])
                        {
                            toplam2 += not[2][i];
                            sayac2++;
                        }
                        if (Convert.ToString(not[0][i]) == ogrenci[0][2])
                        {
                            toplam3 += not[2][i];
                            sayac3++;
                        }
                        if (Convert.ToString(not[0][i]) == ogrenci[0][3])
                        {
                            toplam4 += not[2][i];
                            sayac4++;
                        }
                        if (Convert.ToString(not[0][i]) == ogrenci[0][4])
                        {
                            toplam5 += not[2][i];
                            sayac5++;
                        }
                    }
                    if (sayac1 == 0)
                        Console.WriteLine("{0} {1} Öğrencisine Ait Not Bulunamadı.", ogrenci[1][0], ogrenci[2][0]);
                    else
                        Console.WriteLine("{0} {1}  Tüm Derslerine Ait Ortalaması={2}", ogrenci[1][0], ogrenci[2][0], (float)toplam1 / sayac1);
                    if (sayac2 == 0)
                        Console.WriteLine("{0} {1} Öğrencisine Ait Not Bulunamadı.", ogrenci[1][1], ogrenci[2][1]);
                    else
                        Console.WriteLine("{0} {1}  Tüm Derslerine Ait Ortalaması={2}", ogrenci[1][1], ogrenci[2][1], (float)toplam2 / sayac2);
                    if (sayac3 == 0)
                        Console.WriteLine("{0} {1} Öğrencisine Ait Not Bulunamadı.", ogrenci[1][2], ogrenci[2][2]);
                    else
                        Console.WriteLine("{0} {1}  Tüm Derslerine Ait Ortalaması={2}", ogrenci[1][2], ogrenci[2][2], (float)toplam3 / sayac3);
                    if (sayac4 == 0)
                        Console.WriteLine("{0} {1} Öğrencisine Ait Not Bulunamadı.", ogrenci[1][3], ogrenci[2][3]);
                    else
                        Console.WriteLine("{0} {1}  Tüm Derslerine Ait Ortalaması={2}", ogrenci[1][3], ogrenci[2][3], (float)toplam4 / sayac4);
                    if (sayac5 == 0)
                        Console.WriteLine("{0} {1} Öğrencisine Ait Not Bulunamadı.", ogrenci[1][4], ogrenci[2][4]);
                    else
                        Console.WriteLine("{0} {1}  Tüm Derslerine Ait Ortalaması={2}", ogrenci[1][4], ogrenci[2][4], (float)toplam5 / sayac5);
                    Console.WriteLine("");
                    Console.WriteLine("Veriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                    Console.ReadLine();
                    goto bas;

                case '0':
                    break;
            }
        }
    }
}//Muhammed_Sağlam_201713709005
