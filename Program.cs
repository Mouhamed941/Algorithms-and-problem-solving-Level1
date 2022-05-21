using static System.Console;

// 1 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan 
//n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

System.Console.WriteLine("Lütfen girmek istediğniz sayıların saysısını giriniz");
int sayilarSayisi = int.Parse(Console.ReadLine());
int[] sayilar = new int[sayilarSayisi];
for (int i = 0; i < sayilarSayisi; i++){
    System.Console.WriteLine("Lütfen {0} sayı giriniz",i+1);
    sayilar[i] = int.Parse(Console.ReadLine());
}
System.Console.WriteLine("girilen çift sayılar aşağıda listelenmektedir :");
int toplam =0;
int sayilarToplami = 0;
foreach (var sayi in sayilar)
{
    
    if (sayi %2 == 0)
    {
        System.Console.WriteLine(sayi);
        toplam+=1;
        sayilarToplami+=sayi;
    }
}
System.Console.WriteLine("Çift Sayıların sayısı :"+toplam);
System.Console.WriteLine("Çift Sayıların Toplamı :"+sayilarToplami);


//2 Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan
//n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri
//console'a yazdırın.
WriteLine("Lütfen iki pozitif sayı giriniz");

WriteLine("birinci sayı giriniz: ");
string sayi1str  = ReadLine();
int sayi1 ;
while (!int.TryParse(sayi1str,out sayi1 ))
{
    WriteLine("Yanlış değer girildi lütfen tekrar deneyin");
    WriteLine("birinci sayı giriniz: ");
    sayi1str  = ReadLine();
}
WriteLine("ikinci sayı giriniz: ");
string sayi2str  = ReadLine();
int sayi2 ;


while (!int.TryParse(sayi2str,out sayi2 ))
{
    WriteLine("Yanlış değer girildi lütfen tekrar deneyin");
    WriteLine("ikinci sayı giriniz: ");
    sayi2str  = ReadLine();
}
int[] dizi = new int[sayi1];

for (int i = 0; i < sayi1; i++)
{   
   WriteLine("{0}.i sayi giriniz: ",i+1); 
   string karşılaştırıcakSayıStr = ReadLine();
   int karşılaştırıcakSayı;
   while (!int.TryParse(karşılaştırıcakSayıStr,out karşılaştırıcakSayı))
   {
       WriteLine("Yanlış değer girildi lütfen tekrar deneyin");
        WriteLine("{0}.i sayi giriniz: ",i+1);
        karşılaştırıcakSayıStr = ReadLine();
    
   }
   dizi[i] = karşılaştırıcakSayı;
}
WriteLine("***Results***");
foreach (var item in dizi)
{
    if (item == sayi2 || item%sayi2 ==0)
    {
       
        Array.Sort(dizi);
        WriteLine(item);
        
        
    }
}
//Validation user input:
string input;
int anInt;
WriteLine("Lütfen pozitif bir sayi giriniz: ");
input = ReadLine();

while (!int.TryParse(input,out anInt))
{
    WriteLine("yanlış veri girildi tekrer deneyin");
    WriteLine("Lütfen pozitif bir sayi giriniz: ");
    input = ReadLine();
}
WriteLine("Girdiğiniz Değer:{0} ",anInt);

// 3:
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n
// adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın


        
WriteLine("Lütfe girmek istediğiniz kelimelerin sayısını giriniz:");
string kelimeSayisiStr = ReadLine();
int kelimeSayisi;
while (!int.TryParse(kelimeSayisiStr,out kelimeSayisi))
{
    WriteLine("yanlış veri girildi tekrer deneyin");
    WriteLine("Lütfe girmek istediğiniz kelimelerin sayısını giriniz:");
    kelimeSayisiStr = ReadLine();
}
string[] kelimeler = new string[kelimeSayisi];
for (int i = 0; i < kelimeSayisi; i++)
{
    WriteLine("Lütfen {0}i. kelimeyi giriniz",i+1);
    string kelime = ReadLine();
    kelimeler[i] = kelime;
    
}
foreach (var item in kelimeler)
{
   WriteLine(Reverse(item));
   
}

static string Reverse( string s )
{
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
}

//4-
//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam 
//kelime ve harf sayısını console'a yazdırın.
WriteLine("Lütfen bir cümle yzınız: ");
string cumle;
cumle = Console.ReadLine();
int count =1,len =0, harfSayisi=0;
while (len <= cumle.Length-1)
{
    if (cumle[len] ==' ' || cumle[len] == '\n'|| cumle[len] =='\t')
    {
        count++;
    }
    if (cumle[len] !=' ' && cumle[len]!= '\n'&& cumle[len] !='\t')
    {
        harfSayisi++;
    }

    len++;

}
WriteLine("Toplam kelime sayısı : "+count);
WriteLine("Toplam harf  sayısı : "+harfSayisi);
