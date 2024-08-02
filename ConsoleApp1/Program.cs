// Soru-1 -> Merhaba, nasılsın, iyiyim, sen nasılsın çıktılarını alt alta yazdır

//Console.WriteLine("Merhaba\nnasılsın\niyiyim\nsen nasılsın");

// Soru-2 -> Bir adet metinsel bir adet tamsayı verisi tanımlayıp değer verip çıktı al.

//string metin = "ahmet";
//int sayi = 5;

//Console.WriteLine($"{metin} --- {sayi}");

// Soru-3 -> Rastgele bir sayı üretip , ekrana yazdır

//Random rnd = new Random();
//int randomSayi = rnd.Next();

//Console.WriteLine("" + randomSayi);

// Soru-4 -> - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

//Random rnd = new Random();
//int randomSayi = rnd.Next();

//int islem = randomSayi % 3;

//Console.WriteLine("" + islem);

// Soru-5 -> Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

//Console.WriteLine("Yaşınız kaç?");
//int yas = Convert.ToInt32(Console.ReadLine());

//if (yas > 18)
//    Console.WriteLine("+");
//else 
//    Console.WriteLine("-");

// Soru-6 ->  Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

//string yaz = "Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.";

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(yaz);
//}

// Soru-7 -> Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

//string name1 = "Gülse Birsel";
//string name2 = "Demet evgar";

//Console.WriteLine($"Önceden name 1 {name1} ve name2 {name2}");
//string depo = name1;

//name1 = name2;
//name2 = depo;

//Console.WriteLine($"Şimdi name 1 {name1} ve name2 {name2}");

// Soru-8 -> Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

//BenDegerDondurmem();
//void BenDegerDondurmem()
//{
//    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
//}

// Soru-9 -> 2 sayı alıp toplam değerini geri döndüren metot.

//toplama(3, 5);

//static int toplama(int sayi1, int sayi2)
//{
//    int toplam = sayi1 + sayi2;
//    return toplam;  
//}

// Soru-10 ->  

//string deneme = kullancıdanGirilenDeger(true);
//Console.WriteLine(""+deneme);

//string kullancıdanGirilenDeger(bool deger)
//{
//    return deger ? "Giriş Başarılı" : "Giriş Başarısız..";
//}
// Soru-11 -> 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

//int karsilastir(int sayi1, int sayi2, int sayi3)
//{

//    int enbuyuk = sayi1;

//    if (enbuyuk < sayi2)
//        enbuyuk = sayi2;

//    if (enbuyuk < sayi3)
//        enbuyuk = sayi3;

//    return enbuyuk;

//}

//int sonuc = karsilastir(23, 45, 12);
//Console.WriteLine("en büyük sayı"+sonuc);

// Soru -12 Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

// Neyse bunu yapamadım
//int EnBuyukSayiyiBul(int x)
//{
//    int mindeger = int.MinValue;
    

//    while (true)
//    {
//        Console.WriteLine("sayı giriniz");
//        int sayi = Convert.ToInt32(Console.ReadLine());

//        if (sayi > mindeger)
//        {

//            Console.WriteLine("En buyuk sayi"+sayi);
//        }

//    }
//}



//EnBuyukSayiyiBul(sayi);









// Soru -13 -> Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.


//void YerDegistir(ref string x, ref string y)
//{
//    string depo = x;
//    x = y;
//    y= depo;

//    Console.WriteLine(""+x+y);
//}

//string name1 = "ahmet";
//string name2 = "ayşe";

//YerDegistir( ref name1,ref name2);

//Console.WriteLine(""+name1+name2);


// Soru-14 ->  Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

//Console.WriteLine("sayi giriniz");
//int sayi=Convert.ToInt32(Console.ReadLine());

//bool sonuc = TekCift(sayi);
//Console.WriteLine(""+sonuc);
//bool TekCift(int sayi)
//{
//    if (sayi % 2 == 0)
//        return false;

//    else
//        return true;
//}

// Soru-15 -> Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
//int yol(int hiz, int zaman)
//{
//    int hesap = hiz * zaman;
//    return hesap;  
//}

//int yolhesabı = yol(3, 4);
//Console.WriteLine(""+yolhesabı);

// Soru-16 -> 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

//void Alan(double yaricap)
//{
//    double dairealan = Math.PI * Math.Pow(yaricap, 2);
//    Console.WriteLine(""+dairealan);
//}

//Alan(3);

//Soru-17 -> "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.

//string metin = "Zaman bir GeRi SayIm cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.";
//Console.WriteLine(metin.ToUpper());
//Console.WriteLine(metin.ToLower());

// Soru-18 ->   "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

//string metin = "              selamssss           ";

//Console.WriteLine(""+metin);

//string kalici = metin.Trim();

//Console.WriteLine(""+kalici);