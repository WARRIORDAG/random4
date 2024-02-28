// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Turkcell C Sharp 201 random  ve diğer konular son part");
// Random sınıfı!! 
/*
int sayi;

Random r = new Random();    //random sınıfından r adında nesne türetmiş oldum!!
sayi = r.Next(0,51);        // (0 dahil 51 dahil değil!!)minimum ve maksimum değer verdim arasında kalan rastgele bir değeri dönderecek
Console.WriteLine("rastgele sayı 0 ile 51 arasında: " + sayi);


int sayi1, sayi2;

Random r1 = new Random();    
sayi1 = r1.Next(0,51);       // r1 nesnesi aracılığı ile next  methoduna/ niteliğine ulaşıyorum!!
sayi2 = r1.Next(0,51);       // 0 dahil 51 dahil değil arada kalan rastgele bir değer dönderiyor
Console.WriteLine("rastgele sayılar 0 ile 51 arasında:" + sayi1 + " ve " + sayi2);


Random rn = new Random();
int sehir;
string [] sehirler = {"adana", "urfa", "maraş","bursa", "antep"};

sehir = rn.Next(0, sehirler.Length);    // sehir değişkenine 0 ile şehirler dizisinin uzunluğu arasında rastgele değer getirecek
Console.WriteLine("rastgele şehir: " + sehirler[sehir]);


Console.Read();
*/

//CAPTCHA UYGULAMASI
/*
int d1, d2, d3, d4;
Random rnd = new Random();      // random sınıfından rnd olarak nesne oluşturdum
d1 = rnd.Next(0,10);    // 0 dahil 10 dahil değil rastgele sayılar
d2 = rnd.Next(0,10);
d3 = rnd.Next(0,10);
d4 = rnd.Next(0,10);

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
string [] karakterler = {"a", "A", "b","B","c","C","d","D", "e", "E"};

Console.Write(d1 + karakterler[d2]+ d3+ karakterler[d4]);

Console.Read();
*/

// DOSYA İŞLEMLERİ 
// yeni dosya oluşturma işlemi aşağıda
/*
StreamWriter sw = new StreamWriter("C:\\Users\\user\\Desktop\\deneme2.txt");         // deneme adında txt dosyası oluşturdum
sw.Write("merhaba deli çoban bu metin belhgesini C Sharp ile oluşturdum!!");        // SW NESNESİ üzerinden write metodunu çağırdım
sw.Close();     // yazı işlemi bittikten sonra dosyayı kapat anlamında close metodunu çağırıyorum


StreamWriter sw1 = new StreamWriter("C:\\Users\\user\\Desktop\\deneme4.txt");   // streamwriter sınıfından sw1 adında nesne türetiyorum
string metin ;
Console.WriteLine("metin yaz kardeş: ");    // klavyeden giriş çin duyuru yaptım
metin = Console.ReadLine();     // kalavyeden girişi metin değişkenine atadım
sw1.Write(metin);       //
sw1.Close();


Console.Read();
*/
/*
// DOSYA OKUMA İŞLEMLERİ!!! ******  !!
FileStream fs = new FileStream(@"C:\Users\user\Desktop\deneme4.txt", FileMode.Open, FileAccess.Read);    // file stream sınfından fs adında nesne oluşturdum
StreamReader sr = new StreamReader(fs);
string metin = sr.ReadLine();
while(metin!= null)
{
    Console.WriteLine(metin);
    metin = sr.ReadLine();
}

sr.Close();
fs.Close();

Console.Read();

*/

//EKSTRA YAPILAR!!  ***   ***
/*

Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine(" konsol rengini değiştiriyorum");      // sadece yazının olduğu satırın rengini değiştirdim
//Console.Clear();        // tüm konsolun rengini değiştirmek istiyorsam bu kodu ekleyeceğim!!

Console.ForegroundColor = ConsoleColor.DarkBlue;


Console.Read();
*/

//ÇOK BOYUTLU DİZİLER!! ** 
/*
int [,] sayilar = new int[2,2];     // 2 satır 2 sutun olan bir dizi tanıladım
sayilar[0,0] = 10;      // 1.s atır 1. sutun değeri 10 yaptım
sayilar[0,1] = 20;
sayilar[1,0] = 30;
sayilar[1,1] = 40;       // 2. satır 2. sutun değeri 40 olsun dedim

Console.WriteLine(sayilar[0,1]);


Console.Read();
*/

//YILDIZLARLA ŞEKİL OLUŞTURMA

Console.Write("*****");

Console.Read();

