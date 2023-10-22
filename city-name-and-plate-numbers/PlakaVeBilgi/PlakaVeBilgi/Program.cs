using Microsoft.VisualBasic;
using System.Security.Claims;

Console.WriteLine("***** City Information System *****");
Console.WriteLine();
Console.WriteLine("-------------------------------");
Console.WriteLine();
Console.WriteLine("Enter the license plate number of the city you want to get information from.");
Console.WriteLine();


int plaka;
plaka = Convert.ToInt32(Console.ReadLine());

switch (plaka)
{
    case 01:
        Console.WriteLine();
        Console.WriteLine("Adana City. Population : 2,263,373 ");
        break;
    case 02:
        Console.WriteLine();
        Console.WriteLine("Adıyaman City. Population : 632,148 ");
        break;
    case 03:
        Console.WriteLine();
        Console.WriteLine("Afyonkarahisar City. Population : 744,179");
        break;
    case 04:
        Console.WriteLine();
        Console.WriteLine("Ağrı City. Population : 539,657");
        break;
    case 05:
        Console.WriteLine();
        Console.WriteLine("Amasya City. Population : 335,351 ");
        break;
    case 06:
        Console.WriteLine();
        Console.WriteLine("Ankara City. Population : 5,747,325 ");
        break;
    case 07:
        Console.WriteLine();
        Console.WriteLine("Antalya City. Population : 2,619,832 ");
        break;
    case 08:
        Console.WriteLine();
        Console.WriteLine("Artvin City. Population : 169,543 ");
        break;
    case 09:
        Console.WriteLine();
        Console.WriteLine("Aydın City. Population : 1,134,031 ");
        break;
    case 10:
        Console.WriteLine();
        Console.WriteLine("Balıkesir City. Population : 1,250,610 ");
        break;
    case 11:
        Console.WriteLine();
        Console.WriteLine("Bilecik City. Population : 228,334 ");
        break;
    case 12:
        Console.WriteLine();
        Console.WriteLine("Bingöl City. Population : 283,112 ");
        break;
    case 13:
        Console.WriteLine();
        Console.WriteLine("Bitlis City. Population : 352,277 ");
        break;
    case 14:
        Console.WriteLine();
        Console.WriteLine("Bolu City. Population : 320,014 ");
        break;
    case 15:
        Console.WriteLine();
        Console.WriteLine("Burdur City. Population : 273,716 ");
        break;
    case 16:
        Console.WriteLine();
        Console.WriteLine("Bursa City. Population : 3,147,818 ");
        break;
    case 17:
        Console.WriteLine();
        Console.WriteLine("Çanakkale City. Population : 557,276 ");
        break;
    case 18:
        Console.WriteLine();
        Console.WriteLine("Çankırı City. Population : 196.515 ");
        break;
    case 19:
        Console.WriteLine();
        Console.WriteLine("Çorum City. Population : 526,282 ");
        break;
    case 20:
        Console.WriteLine();
        Console.WriteLine("Denizli City. Population : 1,051,056 ");
        break;
    case 21:
        Console.WriteLine();
        Console.WriteLine("Diyarbakır City. Population : 1,791,373 ");
        break;
    case 22:
        Console.WriteLine();
        Console.WriteLine("Edirne City. Population : 412,115 ");
        break;
    case 23:
        Console.WriteLine();
        Console.WriteLine("Elazığ City. Population : 588,088 ");
        break;
    case 24:
        Console.WriteLine();
        Console.WriteLine("Erzincan City. Population : 237,531 ");
        break;
    case 25:
        Console.WriteLine();
        Console.WriteLine("Erzurum City. Population : 756.893 ");
        break;
    case 26:
        Console.WriteLine();
        Console.WriteLine("Eskişehir City. Population : 898,369 ");
        break;
    case 27:
        Console.WriteLine();
        Console.WriteLine("Gaziantep City. Population : 2,130,432 ");
        break;
    case 28:
        Console.WriteLine();
        Console.WriteLine("Giresun City. Population : 450,154 ");
        break;
    case 29:
        Console.WriteLine();
        Console.WriteLine("Gümüşhane City. Population : 150,119 ");
        break;
    case 30:
        Console.WriteLine();
        Console.WriteLine("Hakkari City. Population : 278,218 ");
        break;
    case 31:
        Console.WriteLine();
        Console.WriteLine("Hatay City. Population : 1,670,712 ");
        break;
    case 32:
        Console.WriteLine();
        Console.WriteLine("Isparta City. Population : 445,678 ");
        break;
    case 33:
        Console.WriteLine();
        Console.WriteLine("Mersin City. Population : 1,891,145 ");
        break;
    case 34:
        Console.WriteLine();
        Console.WriteLine("İstanbul City. Population : 15,840,900 ");
        break;
    case 35:
        Console.WriteLine();
        Console.WriteLine("İzmir City. Population : 4,425,789 ");
        break;
    case 36:
        Console.WriteLine();
        Console.WriteLine("Kars City. Population : 281,077 ");
        break;
    case 37:
        Console.WriteLine();
        Console.WriteLine("Kastamonu City. Population : 375,592 ");
        break;
    case 38:
        Console.WriteLine();
        Console.WriteLine("Kayseri City. Population : 1,434,357 ");
        break;
    case 39:
        Console.WriteLine();
        Console.WriteLine("Kırklareli City. Population : 366,363 ");
        break;
    case 40:
        Console.WriteLine();
        Console.WriteLine("Kırşehir City. Population : 242,944 ");
        break;
    case 41:
        Console.WriteLine();
        Console.WriteLine("Kocaeli City. Population : 2,033,441 ");
        break;
    case 42:
        Console.WriteLine();
        Console.WriteLine("Konya City. Population : 2,277,017 ");
        break;
    case 43:
        Console.WriteLine();
        Console.WriteLine("Kütahya City. Population : 578,640 ");
        break;
    case 44:
        Console.WriteLine();
        Console.WriteLine("Malatya City. Population : 808,626 ");
        break;
    case 45:
        Console.WriteLine();
        Console.WriteLine("Manisa City. Population : 1,456,626 ");
        break;
    case 46:
        Console.WriteLine();
        Console.WriteLine("Kahramanmaraş City. Population : 1,171,298 ");
        break;
    case 47:
        Console.WriteLine();
        Console.WriteLine("Mardin City. Population : 862,757 ");
        break;
    case 48:
        Console.WriteLine();
        Console.WriteLine("Muğla City. Population :  1,021,141");
        break;
    case 49:
        Console.WriteLine();
        Console.WriteLine("Muş City. Population : 405,228 ");
        break;
    case 50:
        Console.WriteLine();
        Console.WriteLine("Nevşehir City. Population : 308,003 ");
        break;
    case 51:
        Console.WriteLine();
        Console.WriteLine("Niğde City. Population : 363,725 ");
        break;
    case 52:
        Console.WriteLine();
        Console.WriteLine("Ordu City. Population : 760,872 ");
        break;
    case 53:
        Console.WriteLine();
        Console.WriteLine("Rize City. Population : 345,662 ");
        break;
    case 54:
        Console.WriteLine();
        Console.WriteLine("Sakarya City. Population : 1,060,876 ");
        break;
    case 55:
        Console.WriteLine();
        Console.WriteLine("Samsun City. Population : 1,371,274 ");
        break;
    case 56:
        Console.WriteLine();
        Console.WriteLine("Siirt City. Population : 331,980 ");
        break;
    case 57:
        Console.WriteLine();
        Console.WriteLine("Sinop City. Population : 218,408 ");
        break;
    case 58:
        Console.WriteLine();
        Console.WriteLine("Sivas City. Population : 636,121 ");
        break;
    case 59:
        Console.WriteLine();
        Console.WriteLine("Tekirdağ City. Population : 1,113,400 ");
        break;
    case 60:
        Console.WriteLine();
        Console.WriteLine("Tokat City. Population : 602,567 ");
        break;
    case 61:
        Console.WriteLine();
        Console.WriteLine("Trabzon City. Population : 816,684 ");
        break;
    case 62:
        Console.WriteLine();
        Console.WriteLine("Tunceli City. Population : 83,645 ");
        break;
    case 63:
        Console.WriteLine();
        Console.WriteLine("Şanlıurfa City. Population : 2,143,020 ");
        break;
    case 64:
        Console.WriteLine();
        Console.WriteLine("Uşak City. Population : 373,183 ");
        break;
    case 65:
        Console.WriteLine();
        Console.WriteLine("Van City. Population : 1,141,015 ");
        break;
    case 66:
        Console.WriteLine();
        Console.WriteLine("Yozgat City. Population : 418,500 ");
        break;
    case 67:
        Console.WriteLine();
        Console.WriteLine("Zonguldak City. Population : 589,684 ");
        break;
    case 68:
        Console.WriteLine();
        Console.WriteLine("Aksaray City. Population : 429,069 ");
        break;
    case 69:
        Console.WriteLine();
        Console.WriteLine("Bayburt City. Population : 850,042 ");
        break;
    case 70:
        Console.WriteLine();
        Console.WriteLine("Karaman City. Population : 258,838 ");
        break;
    case 71:
        Console.WriteLine();
        Console.WriteLine("Kırıkkale City. Population : 275,968 ");
        break;
    case 72:
        Console.WriteLine();
        Console.WriteLine("Batman City. Population : 626,319 ");
        break;
    case 73:
        Console.WriteLine();
        Console.WriteLine("Şırnak City. Population : 546,589 ");
        break;
    case 74:
        Console.WriteLine();
        Console.WriteLine("Bartın City. Population : 201,711 ");
        break;
    case 75:
        Console.WriteLine();
        Console.WriteLine("Ardahan City. Population : 94,932 ");
        break;
    case 76:
        Console.WriteLine();
        Console.WriteLine("Iğdır City. Population : 203,159 ");
        break;
    case 77:
        Console.WriteLine();
        Console.WriteLine("Yalova City. Population : 291,001 ");
        break;
    case 78:
        Console.WriteLine();
        Console.WriteLine("Karabük City. Population : 249,287 ");
        break;
    case 79:
        Console.WriteLine();
        Console.WriteLine("Kilis City. Population : 145,826 ");
        break;
    case 80:
        Console.WriteLine();
        Console.WriteLine("Osmaniye City. Population : 553,012 ");
        break;
    case 81:
        Console.WriteLine();
        Console.WriteLine("Düzce City. Population : 400,976 ");
        break;
    default:
        Console.WriteLine();
        Console.WriteLine("Unknown city plate number");
        break;
}

Console.WriteLine();
Console.WriteLine("***** Thank you ***** ");
Console.WriteLine();
Console.WriteLine("----------------------");