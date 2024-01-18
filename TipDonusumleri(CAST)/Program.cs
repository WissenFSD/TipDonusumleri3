// See https://aka.ms/new-console-template for more information

// ToString
// Convert
// Parse
// Cast


// küçük tip büyük tip'ê çevrildiğinde bir veri kaybı olmayacağı için her hangi bir tip dönüşümü yapmamıza gerek kalmıyor

// küçük tip büyük tipe atandı
//byte a = 10;
//int b = a;

// daha büyük olanın daha küçük olan tipe dönüşümünde gerçekleşlir(Bu senaryo da bilinçli bir şekilde tip dönüşümünü onaylamamız gerekiyor)
//int buyukTip = 10;
//byte kucukTip = (byte)buyukTip;


// Ondalık sayılar
// Ondalik sayı tam sayıya çevrildiğinde ondalık kısmı yok olacaktır. Bu tip dönüşümüne dikkat etmelisiniz.
//double ondalik = 10.6;
//int ondalikOlmayan = (int)ondalik;
//Console.WriteLine(ondalikOlmayan);


// Cast yöntemi ile string char'a dönüştürülemez
//string degisken = "Merhaba";
//char tekKarakter = (char)degisken;

// Bu şekilde de yöntem değildir.
//string tekKarakterString = "A";
//char tekKarakterChar = (char)tekKarakterString;


// Büyük değer taşıyab değişken , küçük değer taşıyan değişkene atandığı zaman, veri kaybı olacaktır.
//int sayi = 260;
//byte kucukSayi = (byte)sayi;
//Console.WriteLine(kucukSayi);


// Char'da string ifadesine dönüştürülemez(ToString kullanılır.)
char tekKarakter = 'a';
string cokKarakter = tekKarakter.ToString();











 




