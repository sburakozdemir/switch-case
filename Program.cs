int month = DateTime.Now.Month;
switch (month)
{
    case 1 :
    Console.WriteLine("Ocak Ayındasınız");
    break;
     case 2 :
    Console.WriteLine("Şubat Ayındasınız");
    break;
     case 12 :
    Console.WriteLine("Aralık Ayındasınız");
    break;


    default:
    Console.WriteLine("Yanlış Veri Girişi");
    break;
}

switch (month)
{
     case 12:
     case 1:
     case 2:
        Console.WriteLine("Kış Ayındasınız");
        break;

    default:
    break;
}