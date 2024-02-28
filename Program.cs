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

//Console.Write("*****");
/*
for (int i =1; i <=10; i++ )
{
    Console.WriteLine("*");
    Console.Writeline();
    Console.WriteLine("*****")
}

Console.Read();

*/

// YILDIZLARLA DİK ÜÇGEN OLUŞTURMA
/*
for (int i = 1; i <=5; i++)
{
    for (int j =1; j <=i; j ++)     // j küçük eşit i önemli !!!
    {
        Console.Write("*");
    }
    Console.WriteLine("--*");
}

Console.Read();
*/

// HATA YÖNETİMİ TRY - CATCH - FINALLY - 
/*
try
{

    int sayi1, sayi2, sonuc;
    Console.WriteLine("1. sayıyı giriniz: ");
    sayi1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz: ");
    sayi2 = Convert.ToInt16(Console.ReadLine());        //dönüşüm yapmayı unutma

    sonuc = sayi1*sayi2;
    Console.WriteLine("sayı 1ve sayı 2nin çarpımı: " + sonuc);
    
}

catch       // hata vermeyecek aşağıdaki uyarıyıgösterecek!!
{
    Console.WriteLine("hata var kardeş");
    
}

Console.Read();
*/

// exception dahil ediyorum!! ***
/*
try
{

    int sayi1, sayi2, sonuc;
    Console.WriteLine("1. sayıyı giriniz: ");
    sayi1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz: ");
    sayi2 = Convert.ToInt16(Console.ReadLine());        //dönüşüm yapmayı unutma

    sonuc = sayi1*sayi2;
    Console.WriteLine("sayı 1ve sayı 2nin çarpımı: " + sonuc);
    
}

catch(Exception ex)       // exception sınıfından ex isimli nesne türettim
{
    Console.WriteLine("hata var kardeş");
    Console.WriteLine(ex);       //exception dan gelen hatayı burada yazdırmasını istiyorum
    
}

Console.Read();
*/

// FORMAT EXCEPTION KONUSU YUKARIDAKİ ÖRNEĞİ KULLANIYORUM!!
/*
try
{

    int sayi1, sayi2, sonuc;
    Console.WriteLine("1. sayıyı giriniz: ");
    sayi1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz: ");
    sayi2 = Convert.ToInt16(Console.ReadLine());        //dönüşüm yapmayı unutma

    sonuc = sayi1*sayi2;
    Console.WriteLine("sayı 1ve sayı 2nin çarpımı: " + sonuc);
    
}

catch(FormatException)       // Format exception sadece değişken türü ile ilgili konularda çalışıyor diğer hata türlerinde alttaki mesajı göstermez!!!
{
    Console.WriteLine("Lütfen sadece sayısal değerler giriniz!");   // girilen değerler sayısal değerler olmazsa format exception çalışır!!!**
        
}

Console.Read();
*/

// OVER FLOW EXCEPTION KONUSU 

/*
try
{

    int sayi1, sayi2, sonuc;
    Console.WriteLine("1. sayıyı giriniz: ");
    sayi1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz: ");
    sayi2 = Convert.ToInt16(Console.ReadLine());        //dönüşüm yapmayı unutma

    sonuc = sayi1*sayi2;
    Console.WriteLine("sayı 1ve sayı 2nin çarpımı: " + sonuc);
    
}

catch(FormatException)       // Format exception sadece değişken türü ile ilgili konularda çalışıyor diğer hata türlerinde alttaki mesajı göstermez!!!
{
    Console.WriteLine("Lütfen sadece sayısal değerler giriniz!");   // girilen değerler sayısal değerler olmazsa format exception çalışır!!!**
        
}
catch(OverflowException)
{
    Console.WriteLine("lütfen belirli aralıklarda değer girin örnek INT16 aralığı!");   // iki farklı catch yapısı kullandım hataları azaltmak için 
}

Console.Read();

*/

// FINALLY KONUSU!!

try
{

    int sayi1, sayi2, sonuc;
    Console.WriteLine("1. sayıyı giriniz: ");
    sayi1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz: ");
    sayi2 = Convert.ToInt16(Console.ReadLine());        //dönüşüm yapmayı unutma

    sonuc = sayi1*sayi2;
    Console.WriteLine("sayı 1ve sayı 2nin çarpımı: " + sonuc);
    
}

catch(Exception)       
{
    Console.WriteLine("Hata!");       
}

finally     // hata yakalanmasına rağmen finally bloğu çalışacak!!!
{
    Console.WriteLine("burası çalıştı!!");

}

Console.Read();

