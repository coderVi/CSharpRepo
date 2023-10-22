Console.WriteLine("3 Yanlış Haklı Bilgi Yarışması");
Console.WriteLine("*---------------------*");
Console.WriteLine(" ");
int soru = 1;
int hak = 3;
string cevap;
int dogruCevapSayisi = 0;

while (hak >= 1)
{
    if (soru == 1)
    {
        Console.WriteLine("Türkiye'nin başkenti Neresidir");
        Console.WriteLine(" ");
        Console.WriteLine("A) İstanbul");
        Console.WriteLine("B) Ankara");
        Console.WriteLine("C) Adana");
        cevap = Console.ReadLine();
        if (cevap == "B" || cevap == "b")
        {
            Console.WriteLine("Doğru Cevap");
            Console.WriteLine("***********************************");
            soru++;
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap");
            hak--;
        }
    }
    if (soru == 2)
    {
        Console.WriteLine("Abdülsametin Doğum Günü");
        Console.WriteLine(" ");
        Console.WriteLine("A) 17.12.1998 ");
        Console.WriteLine("B) 19.07.2000");
        Console.WriteLine("C) 21.10.2001");
        cevap = Console.ReadLine();

        if (cevap == "A" || cevap == "a")
        {
            Console.WriteLine("Doğru Cevap");
            Console.WriteLine("***********************************");
            soru++;
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap");
            hak--;
        }
    }
    if (soru == 3)
    {
        Console.WriteLine("İstanbul Hangi Bölgededir");
        Console.WriteLine(" ");
        Console.WriteLine("A) Karadeniz ");
        Console.WriteLine("B) Ege");
        Console.WriteLine("C) Marmara");
        cevap = Console.ReadLine();

        if (cevap == "C" || cevap == "c")
        {
            Console.WriteLine("Doğru Cevap");
            Console.WriteLine("***********************************");
            soru++;
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap");
            hak--;
        }
    }

    if (soru > 3 && dogruCevapSayisi == 3)
    {
        Console.WriteLine("Tebrikler, tüm soruları doğru cevapladınız!");
        break;
    }
    else if (soru > 3 && dogruCevapSayisi != 3)
    {
        Console.WriteLine("Maalesef, yarışmayı tamamladınız ancak tüm soruları doğru cevaplayamadınız.");
        break;
    }
}
Console.WriteLine("Yarışma Sonlanmıştır ");
