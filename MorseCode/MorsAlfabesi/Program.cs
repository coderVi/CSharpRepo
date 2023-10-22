Console.WriteLine("Mors Alfabesi Yazma Uygulaması");
Console.WriteLine("---------------------------------");
Console.WriteLine();

// Mors alfabesi kodlarını tanımlama
string A = ".- ";
string B = "-... ";
string C = "-.-. ";
string D = "-.. ";
string E = ". ";
string F = "..-. ";
string G = "--. ";
string H = ".... ";
string I = ".. ";
string J = ".--- ";
string K = "-.- ";
string L = ".-.. ";
string M = "-- ";
string N = "-. ";
string O = "--- ";
string P = ".--. ";
string Q = "--.- ";
string R = ".-. ";
string S = "... ";
string T = "- ";
string U = "..- ";
string V = "...- ";
string W = ".-- ";
string X = "-..- ";
string Y = "-.-- ";
string Z = "--.. ";
string Ö = "---. ";
string Ü = "..-- ";
string Ç = "---- ";
string Ş = "...-. ";

// Kullanıcıdan metin girmesini isteme
string metin = "";
while (metin == "")
{
    Console.Write("Lütfen çevirmek istediğiniz metni girin: ");
    metin = Console.ReadLine().Trim().ToUpper();

    if (metin == "")
    {
        Console.WriteLine("Lütfen geçerli bir metin girin.");
    }
    else if (!metin.All(char.IsLetterOrDigit))
    {
        Console.WriteLine("Metin sadece harf ve rakamlardan oluşabilir.");
        metin = "";
    }
}

// Metni Mors alfabesiyle çevirme
string morsMetni = "";
foreach (char harf in metin)
{
    switch (harf)
    {
        case 'A':
            morsMetni += A;
            break;
        case 'B':
            morsMetni += B;
            break;
        case 'C':
            morsMetni += C;
            break;
        case 'Ç':
            morsMetni += Ç;
            break;
        case 'D':
            morsMetni += D;
            break;
        case 'E':
            morsMetni += E;
            break;
        case 'F':
            morsMetni += F;
            break;
        case 'G':
            morsMetni += G;
            break;
        case 'Ğ':
            morsMetni += "--. ";
            break;
        case 'H':
            morsMetni += H;
            break;
        case 'I':
            morsMetni += I;
            break;
        case 'İ':
            morsMetni += ".. ";
            break;
        case 'J':
            morsMetni += J;
            break;
        case 'K':
            morsMetni += K;
            break;
        case 'L':
            morsMetni += L;
            break;
        case 'M':
            morsMetni += M;
            break;
        case 'N':
            morsMetni += N;
            break;
        case 'O':
            morsMetni += O;
            break;
        case 'Ö':
            morsMetni += Ö;
            break;
        case 'P':
            morsMetni += P;
            break;
        case 'Q':
            morsMetni += Q;
            break;
        case 'R':
            morsMetni += R;
            break;
        case 'S':
            morsMetni += S;
            break;
        case 'Ş':
            morsMetni += Ş;
            break;
        case 'T':
            morsMetni += T;
            break;
        case 'U':
            morsMetni += U;
            break;
        case 'Ü':
            morsMetni += Ü;
            break;
        case 'V':
            morsMetni += V;
            break;
        case 'W':
            morsMetni += W;
            break;
        case 'X':
            morsMetni += X;
            break;
        case 'Y':
            morsMetni += Y;
            break;
        case 'Z':
            morsMetni += Z;
            break;
        case '0':
            morsMetni += "----- ";
            break;
        case '1':
            morsMetni += ".---- ";
            break;
        case '2':
            morsMetni += "..--- ";
            break;
        case '3':
            morsMetni += "...-- ";
            break;
        case '4':
            morsMetni += "....- ";
            break;
        case '5':
            morsMetni += "..... ";
            break;
        case '6':
            morsMetni += "-.... ";
            break;
        case '7':
            morsMetni += "--... ";
            break;
        case '8':
            morsMetni += "---.. ";
            break;
        case '9':
            morsMetni += "----. ";
            break;
        case ' ':
            morsMetni += "  ";
            break;
        default:
            break;
    }
}

// Mors metnini ekrana yazdırma
Console.WriteLine();
Console.WriteLine($"Girdiğiniz metin: {metin}");
Console.WriteLine($"Mors alfabesiyle: {morsMetni}");

// Uygulamanın kapanması için bekleyin
Console.Write("Çıkmak için Enter tuşuna basın...");
Console.ReadLine();