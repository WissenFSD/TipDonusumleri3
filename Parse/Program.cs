// See https://aka.ms/new-console-template for more information

// ToString her şeyi string'ê çevirmek için kullanılır
// Parse ise her şeyi stringden çevirmek için kullanır


// string tipindeki 10 değerini sayısal değer olan int tipine parse ile çevirdik 
string sayi = "10";
int intSayi = int.Parse(sayi);


// string tipini btye tipine çevirme

string stringSayi = "50";
byte byteSayi = byte.Parse(stringSayi);


#region Örnek
// Kullanıcıdan string değer alıp, int bir diziyi dolduran bir örnek yapalım(Parse ile)

//Console.WriteLine("Değer gir");
//int deger =int.Parse( Console.ReadLine());

//int[] dizi = new int[deger];
//int toplam = 0;
//for (int i = 0; i < deger; i++)
//{
//    Console.WriteLine("{0}. sayıyı gir",i);
//    dizi[i]=int.Parse(Console.ReadLine());
//    toplam += dizi[i];
//}
//Console.WriteLine("Veriler alındı. Devam etmek için tuşa bas");
//Console.ReadLine();
//Console.WriteLine("Girilen Sayı Adedi   {0} -- Toplam : {1} --- Ortalama : {2}",deger,toplam,toplam/deger);
#endregion

#region Örnek 2

// girilen tüm sayıların benzersiz olup olmadığını kontrol ediniz kod örneğini yazınız
// Ev Ödevi

