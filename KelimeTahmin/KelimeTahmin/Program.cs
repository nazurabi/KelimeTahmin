using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeTahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Karşılama ve Tahmin Kelimesinin Alınması

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
            Console.ResetColor();
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.Write("Lütfen tahmin edilecek kelimeyi giriniz ve enter tuşuna basınız= ");
            Console.ForegroundColor = ConsoleColor.Green;
            string kelime = Console.ReadLine(); // 1.Oyuncunun girdiği kelime
            char[] tahminedilecek = new char[kelime.Length];
            for (int i = 0; i < kelime.Length; i++) // 1.Oyuncunun girdiği kelimeyi sansürlüyoruz
            {
                if (kelime[i] != ' ')
                {
                    tahminedilecek[i] += '_';
                }
                else
                {
                    tahminedilecek[i] += '/';
                }
            }
            Console.ResetColor();
            Console.Clear();
            byte hak = 0;

            #endregion

            #region Zorluk Seçimi

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                Console.ResetColor();
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("1) Kolay Seviye --- 10 Hak");
                Console.WriteLine("2) Orta Seviye --- 5 Hak");
                Console.WriteLine("3) Zor Seviye ---3 Hak");
                Console.Write("Lütfen bir zorluk seviyesi seçiniz= ");
                Console.ForegroundColor = ConsoleColor.Green;
                string zorluk = Console.ReadLine();
                Console.ResetColor();

                if (zorluk == "1")
                {
                    hak = 10;
                    break;
                }
                else if (zorluk == "2")
                {
                    hak = 5;
                    break;
                }
                else if (zorluk == "3")
                {
                    hak = 3;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Belirtilen seçenekler dışında bir seçim yaptınız, Lütfen listedekilerden birini seçiniz");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
            #endregion

            #region Seçimler ve Sonuçlar

            bool tahminedilebildimi = true;
            string yanlisharfler = "";
            switch (hak)
            {
                case 10:
                    for (int i = hak; i > 0; i--)
                    {
                        bool arananvarmi = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                        Console.ResetColor();
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        Console.Write("1.Zorluk Seviyesindesiniz toplam ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(i);
                        Console.ResetColor();
                        Console.WriteLine(" hakkınız bulunmaktadır.");
                        Console.WriteLine("");
                        Console.Write($"Tahmin Edilecek Kelime= ");
                        Console.WriteLine(tahminedilecek);// 1.Oyuncunun girdiği ve sansürleyerek char dizisi oluşturduğumuz kelime dizisini referans olması açısından sansürlenmiş şekilde tahmin edecek 2.Oyuncuya gösteriyoruz.
                        Console.WriteLine("");
                        Console.Write("Yanlış Tahmin Edilen Harfler=");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(yanlisharfler);
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Harf tahmin etme adımından çıkıp kelimenin tamamını tahmin etmek istiyor musunuz?");
                        Console.Write("Eğer kabul ederseniz kalan tahmin haklarınız kaybolacaktır. e/h= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string secenek = Console.ReadLine();
                        Console.ResetColor();
                        if (secenek == "e")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                            Console.ResetColor();
                            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                            Console.WriteLine("1.Zorluk Seviyesindesiniz ");
                            Console.WriteLine("");
                            Console.Write($"Tahmin Edilecek Kelime= ");
                            Console.WriteLine(tahminedilecek);
                            Console.WriteLine("");
                            Console.Write("Yanlış Tahmin Edilen Harfler=");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(yanlisharfler);
                            Console.ResetColor();
                            Console.WriteLine("");
                            Console.Write("Lütfen tahminde bulununuz eğer birden fazla kelimeden oluşuyorsa '/' işareti yerine boşluk tuşunu kullanınız= ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            string tamtahmin = Console.ReadLine();
                            Console.ResetColor();
                            if (tamtahmin == kelime)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Tebrikler Kazandınız");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Maalesef Kazanamadınız");
                                Console.ResetColor();
                                break;
                            }
                        }
                        else if (secenek == "h")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                            Console.ResetColor();
                            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                            Console.Write("1.Zorluk Seviyesindesiniz toplam ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(i);
                            Console.ResetColor();
                            Console.WriteLine(" hakkınız bulunmaktadır.");
                            Console.WriteLine("");
                            Console.Write($"Tahmin Edilecek Kelime= ");
                            Console.WriteLine(tahminedilecek);
                            Console.WriteLine("");
                            Console.Write("Yanlış Tahmin Edilen Harfler=");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(yanlisharfler);
                            Console.ResetColor();
                            Console.WriteLine("");
                            Console.Write("Tahminde Bulunmak İstediğiniz Harfi/Rakamı Giriniz= ");
                            char tahminedilen = ' ';
                            while (true) // 2.Oyuncunun sadece 1 karakter girmiş olduğundan emin olmak için döngü kuruyoruz, istenilen şartı sağlamazsa sonsuz döngüye girip kod satırının devamına hiçbir şekilde geçemeyecek
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                string tahminedilenkontrol = Console.ReadLine();
                                Console.ResetColor();
                                if (!(tahminedilenkontrol.Length > 1) && tahminedilenkontrol.Length != 0)
                                {
                                    tahminedilen = Convert.ToChar(tahminedilenkontrol);
                                    break;// İstenilen şartı sağladıysa döngüyü burada kırıyoruz
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Lütfen sadece bir karakterli tahminde bulununuz!");
                                    Console.ResetColor();
                                }
                            }

                            for (int j = 0; j < kelime.Length; j++)
                            {
                                if (kelime[j] == tahminedilen)
                                {
                                    tahminedilecek[j] = tahminedilen;// Sansürlü kelimeleri doğru tahmin edilen ile değiştirdiğimiz kod
                                    arananvarmi = true;
                                }
                            }
                            if (arananvarmi == false)
                            {
                                yanlisharfler += tahminedilen + ",";
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Belirtilen seçenekler dışında bir seçim yaptınız, Lütfen e/h seçiniz");
                            Console.ResetColor();
                            i++;
                            Console.ReadKey();
                        }
                        if (i == 1)
                        {
                            tahminedilebildimi = false;
                        }
                    }
                    if (tahminedilebildimi == false)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                        Console.ResetColor();
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        Console.WriteLine("1.Zorluk Seviyesindesiniz ve tüm haklarınızı bitirdiniz ");
                        Console.WriteLine("");
                        Console.Write($"Tahmin Edilecek Kelime= ");
                        Console.WriteLine(tahminedilecek);
                        Console.WriteLine("");
                        Console.Write("Yanlış Tahmin Edilen Harfler=");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(yanlisharfler);
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.Write("Lütfen tahminde bulununuz eğer birden fazla kelimeden oluşuyorsa '/' işareti yerine boşluk tuşunu kullanınız= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string tamtahmin = Console.ReadLine();
                        Console.ResetColor();
                        if (tamtahmin == kelime)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Tebrikler Kazandınız");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maalesef Kazanamadınız");
                            Console.ResetColor();
                        }
                    }
                    break;

                case 5:
                    for (int i = hak; i > 0; i--)
                    {
                        bool arananvarmi = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                        Console.ResetColor();
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        Console.Write("2.Zorluk Seviyesindesiniz toplam ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(i);
                        Console.ResetColor();
                        Console.WriteLine(" hakkınız bulunmaktadır.");
                        Console.WriteLine("");
                        Console.Write($"Tahmin Edilecek Kelime= ");
                        Console.WriteLine(tahminedilecek);// 1.Oyuncunun girdiği ve sansürleyerek char dizisi oluşturduğumuz kelime dizisini referans olması açısından sansürlenmiş şekilde tahmin edecek 2.Oyuncuya gösteriyoruz.
                        Console.WriteLine("");
                        Console.Write("Yanlış Tahmin Edilen Harfler=");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(yanlisharfler);
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Harf tahmin etme adımından çıkıp kelimenin tamamını tahmin etmek istiyor musunuz?");
                        Console.Write("Eğer kabul ederseniz kalan tahmin haklarınız kaybolacaktır. e/h= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string secenek = Console.ReadLine();
                        Console.ResetColor();
                        if (secenek == "e")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                            Console.ResetColor();
                            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                            Console.WriteLine("2.Zorluk Seviyesindesiniz ");
                            Console.WriteLine("");
                            Console.Write($"Tahmin Edilecek Kelime= ");
                            Console.WriteLine(tahminedilecek);
                            Console.WriteLine("");
                            Console.Write("Yanlış Tahmin Edilen Harfler=");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(yanlisharfler);
                            Console.ResetColor();
                            Console.WriteLine("");
                            Console.Write("Lütfen tahminde bulununuz eğer birden fazla kelimeden oluşuyorsa '/' işareti yerine boşluk tuşunu kullanınız= ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            string tamtahmin = Console.ReadLine();
                            Console.ResetColor();
                            if (tamtahmin == kelime)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Tebrikler Kazandınız");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Maalesef Kazanamadınız");
                                Console.ResetColor();
                                break;
                            }
                        }
                        else if (secenek == "h")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                            Console.ResetColor();
                            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                            Console.Write("2.Zorluk Seviyesindesiniz toplam ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(i);
                            Console.ResetColor();
                            Console.WriteLine(" hakkınız bulunmaktadır.");
                            Console.WriteLine("");
                            Console.Write($"Tahmin Edilecek Kelime= ");
                            Console.WriteLine(tahminedilecek);
                            Console.WriteLine("");
                            Console.Write("Yanlış Tahmin Edilen Harfler=");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(yanlisharfler);
                            Console.ResetColor();
                            Console.WriteLine("");
                            Console.Write("Tahminde Bulunmak İstediğiniz Harfi/Rakamı Giriniz= ");
                            char tahminedilen = ' ';
                            while (true) // 2.Oyuncunun sadece 1 karakter girmiş olduğundan emin olmak için döngü kuruyoruz, istenilen şartı sağlamazsa sonsuz döngüye girip kod satırının devamına hiçbir şekilde geçemeyecek
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                string tahminedilenkontrol = Console.ReadLine();
                                Console.ResetColor();
                                if (!(tahminedilenkontrol.Length > 1) && tahminedilenkontrol.Length != 0)
                                {
                                    tahminedilen = Convert.ToChar(tahminedilenkontrol);
                                    break;// İstenilen şartı sağladıysa döngüyü burada kırıyoruz
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Lütfen sadece bir karakterli tahminde bulununuz!");
                                    Console.ResetColor();
                                }
                            }

                            for (int j = 0; j < kelime.Length; j++)
                            {
                                if (kelime[j] == tahminedilen)
                                {
                                    tahminedilecek[j] = tahminedilen;// Sansürlü kelimeleri doğru tahmin edilen ile değiştirdiğimiz kod
                                    arananvarmi = true;
                                }
                            }
                            if (arananvarmi == false)
                            {
                                yanlisharfler += tahminedilen + ",";
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Belirtilen seçenekler dışında bir seçim yaptınız, Lütfen e/h seçiniz");
                            Console.ResetColor();
                            i++;
                            Console.ReadKey();
                        }

                        if (i == 1)
                        {
                            tahminedilebildimi = false;
                        }
                    }
                    if (tahminedilebildimi == false)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                        Console.ResetColor();
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        Console.WriteLine("2.Zorluk Seviyesindesiniz ve tüm haklarınızı bitirdiniz ");
                        Console.WriteLine("");
                        Console.Write($"Tahmin Edilecek Kelime= ");
                        Console.WriteLine(tahminedilecek);
                        Console.WriteLine("");
                        Console.Write("Yanlış Tahmin Edilen Harfler=");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(yanlisharfler);
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.Write("Lütfen tahminde bulununuz eğer birden fazla kelimeden oluşuyorsa '/' işareti yerine boşluk tuşunu kullanınız= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string tamtahmin = Console.ReadLine();
                        Console.ResetColor();
                        if (tamtahmin == kelime)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Tebrikler Kazandınız");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maalesef Kazanamadınız");
                            Console.ResetColor();
                        }
                    }
                    break;

                case 3:
                    for (int i = hak; i > 0; i--)
                    {
                        bool arananvarmi = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                        Console.ResetColor();
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        Console.Write("3.Zorluk Seviyesindesiniz toplam ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(i);
                        Console.ResetColor();
                        Console.WriteLine(" hakkınız bulunmaktadır.");
                        Console.WriteLine("");
                        Console.Write($"Tahmin Edilecek Kelime= ");
                        Console.WriteLine(tahminedilecek);// 1.Oyuncunun girdiği ve sansürleyerek char dizisi oluşturduğumuz kelime dizisini referans olması açısından sansürlenmiş şekilde tahmin edecek 2.Oyuncuya gösteriyoruz.
                        Console.WriteLine("");
                        Console.Write("Yanlış Tahmin Edilen Harfler=");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(yanlisharfler);
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Harf tahmin etme adımından çıkıp kelimenin tamamını tahmin etmek istiyor musunuz?");
                        Console.Write("Eğer kabul ederseniz kalan tahmin haklarınız kaybolacaktır. e/h= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string secenek = Console.ReadLine();
                        Console.ResetColor();
                        if (secenek == "e")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                            Console.ResetColor();
                            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                            Console.WriteLine("3.Zorluk Seviyesindesiniz ");
                            Console.WriteLine("");
                            Console.Write($"Tahmin Edilecek Kelime= ");
                            Console.WriteLine(tahminedilecek);
                            Console.WriteLine("");
                            Console.Write("Yanlış Tahmin Edilen Harfler=");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(yanlisharfler);
                            Console.ResetColor();
                            Console.WriteLine("");
                            Console.Write("Lütfen tahminde bulununuz eğer birden fazla kelimeden oluşuyorsa '/' işareti yerine boşluk tuşunu kullanınız= ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            string tamtahmin = Console.ReadLine();
                            Console.ResetColor();
                            if (tamtahmin == kelime)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Tebrikler Kazandınız");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Maalesef Kazanamadınız");
                                Console.ResetColor();
                                break;
                            }
                        }
                        else if (secenek == "h")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                            Console.ResetColor();
                            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                            Console.Write("3.Zorluk Seviyesindesiniz toplam ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(i);
                            Console.ResetColor();
                            Console.WriteLine(" hakkınız bulunmaktadır.");
                            Console.WriteLine("");
                            Console.Write($"Tahmin Edilecek Kelime= ");
                            Console.WriteLine(tahminedilecek);
                            Console.WriteLine("");
                            Console.Write("Yanlış Tahmin Edilen Harfler=");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(yanlisharfler);
                            Console.ResetColor();
                            Console.WriteLine("");
                            Console.Write("Tahminde Bulunmak İstediğiniz Harfi/Rakamı Giriniz= ");
                            char tahminedilen = ' ';
                            while (true) // 2.Oyuncunun sadece 1 karakter girmiş olduğundan emin olmak için döngü kuruyoruz, istenilen şartı sağlamazsa sonsuz döngüye girip kod satırının devamına hiçbir şekilde geçemeyecek
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                string tahminedilenkontrol = Console.ReadLine();
                                Console.ResetColor();
                                if (!(tahminedilenkontrol.Length > 1) && tahminedilenkontrol.Length != 0)
                                {
                                    tahminedilen = Convert.ToChar(tahminedilenkontrol);
                                    break;// İstenilen şartı sağladıysa döngüyü burada kırıyoruz
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Lütfen sadece bir karakterli tahminde bulununuz!");
                                    Console.ResetColor();
                                }
                            }
                            for (int j = 0; j < kelime.Length; j++)
                            {
                                if (kelime[j] == tahminedilen)
                                {
                                    tahminedilecek[j] = tahminedilen;// Sansürlü kelimeleri doğru tahmin edilen ile değiştirdiğimiz kod
                                    arananvarmi = true;
                                }
                            }
                            if (arananvarmi == false)
                            {
                                yanlisharfler += tahminedilen + ",";
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Belirtilen seçenekler dışında bir seçim yaptınız, Lütfen e/h seçiniz");
                            Console.ResetColor();
                            i++;
                            Console.ReadKey();
                        }
                        if (i == 1)
                        {
                            tahminedilebildimi = false;
                        }
                    }
                    if (tahminedilebildimi == false)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Kelime Tahmin Oyununa Hoşgeldiniz");
                        Console.ResetColor();
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        Console.WriteLine("3.Zorluk Seviyesindesiniz ve tüm haklarınızı bitirdiniz ");
                        Console.WriteLine("");
                        Console.Write($"Tahmin Edilecek Kelime= ");
                        Console.WriteLine(tahminedilecek);
                        Console.WriteLine("");
                        Console.Write("Yanlış Tahmin Edilen Harfler=");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(yanlisharfler);
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.Write("Lütfen tahminde bulununuz eğer birden fazla kelimeden oluşuyorsa '/' işareti yerine boşluk tuşunu kullanınız= ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string tamtahmin = Console.ReadLine();
                        Console.ResetColor();
                        if (tamtahmin == kelime)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Tebrikler Kazandınız");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maalesef Kazanamadınız");
                            Console.ResetColor();
                        }
                    }
                    break;
            }
            #endregion
        }
    }
}
