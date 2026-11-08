//Console.WriteLine("+--------------------------+");
//Console.WriteLine("|       WIZYTÓWKA          |");
//Console.WriteLine("+--------------------------+");
//Console.WriteLine("| Imię: Filip              |");
//Console.WriteLine("| Wiek: 19                 |");
//Console.WriteLine("| Gra: LOL                 |");
// int a = 19;
// float b = 3;
// string d = "";
// string l = "";
// string f = "";
// char e = 'a';
// Console.WriteLine("Podaj imie");
// d = Console.ReadLine();
// Console.WriteLine("Podaj ulubiony kolor");
// l = Console.ReadLine();
// Console.WriteLine("Podaj co lubisz robić w wolnej chwili");
// f = Console.ReadLine();
// Console.WriteLine($" siema: {d} też bardzo lubie kolor {l}, i bardzo ciekawe jest to że robisz {f} ");
// int a = "";
// float b = "";
// string d = "";
// string l = "";
// string f = "";
//  char e = 'a';

// Console.Write("podaj wiek: ");
// string wiekstring = Console.ReadLine()!;
// Console.Write("twój wiek:"+wiekstring);
// Console.Write("twoj wiek za rok:"+wiekstring+1)
// int wiekInt = int.Parse(wiekstring);
// Console.Write ("twój wiek za rok: "+(wiekInt+1));





// Console.Write("Podaj trase: ");
// string trasastring = Console.ReadLine()!;
// Console.Write("Podaj ile km dziennie: ");
// string dzienniestring = Console.ReadLine()!;
// int trasa = int.Parse(trasastring);
// int dziennie = int.Parse(dzienniestring);

// Console.WriteLine($"Trase {trasa} km jeśli będziesz robił dziennie {dziennie} km zrobisz w {trasa / dziennie} dni.");


// Console.Write("Podaj złote monety: ");
// string zlotee = Console.ReadLine()!;
// Console.Write("Podaj srebrne: ");
// string srebrnee = Console.ReadLine()!;
// Console.Write("Podaj miedziane: ");
// string miedzianee = Console.ReadLine()!;
// int zlote = int.Parse(zlotee);
// int srebrne = int.Parse(srebrnee);
// int miedziane = int.Parse(miedzianee);

// Console.WriteLine($"łącznie masz w przeliczeniu na miedziane masz {(zlote * 100) + (srebrne * 10) + miedziane} monet.");


// Console.Write("Podaj ilosc mikstur: ");
// string mix = Console.ReadLine()!;
// int mikstury = int.Parse(mix);

// Console.WriteLine($"na wykonanie {mikstury} potrzebujesz {mikstury * 3} kryształow i {mikstury * 2} ziół ");

// Console.Write("Podaj kwote nocy: ");
// string no = Console.ReadLine()!;
// decimal n = decimal.Parse(no);

// Console.Write("Podaj ilosc nocy: ");
// string il = Console.ReadLine()!;
// int i = int.Parse(il);

// Console.WriteLine($"koszy pobytu na {i} nocy potrzebujesz {n * i} zl");

// Console.Write("Podaj czas w sek: ");
// string no = Console.ReadLine()!;
// int n = int.Parse(no);

// Console.WriteLine($"{n} sekund to {(n / 60)}min i {n % 60} sekund");

// Console.Write("Podaj ilosć monet: ");
// string no = Console.ReadLine()!;
// int n = int.Parse(no);
// Console.Write("Podaj ilosć ludzi: ");
// string na = Console.ReadLine()!;
// int i = int.Parse(na);

// Console.WriteLine($"{n} monet, {i} ludzi, to {(n / i)} monet na osoobe i na dzieci z domu dziecka zostanie 0.{n % i}  ");




// Console.Write("Podaj dmg: ");
// string no = Console.ReadLine()!;
// int n = int.Parse(no);
// Console.Write("Podaj premie: ");
// string na = Console.ReadLine()!;
// int i = int.Parse(na);

// Console.WriteLine($"zwykły atak zada {n*i} ult zada {(n*i) * 2} a combo zada {((n*i) * 3) + ((n*i) * 2)} ");

// Console.Write("Podaj HP: ");
// string hps = Console.ReadLine()!;
// int hp = int.Parse(hps);

// if (hp <= 0)
// {
//     Console.WriteLine("Nie żyje.");
// }
// else{
// Console.Write("Czy ma klucz (true/false): ");
// string kluczs = Console.ReadLine()!;
// bool klucz = bool.Parse(kluczs);

// Console.Write("Czy zna hasło (true/false): ");
// string haslos = Console.ReadLine()!;
// bool haslo = bool.Parse(haslos);

//     if(klucz || haslo)
//     {
//         Console.WriteLine("Można wejśc");
//     }
//     else
//     {
//         Console.WriteLine("nie ma możliwości wejścia");
//     }
// }

int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;

while(zdrowieBohatera > 0 && zdrowiePrzeciwnika > 0)
{
    Console.WriteLine($"Tura nr: {numerTury}");
    Console.WriteLine($"Bohater - {zdrowieBohatera}  Wróg - {zdrowiePrzeciwnika}");
    numerTury++;
    Console.Write("Wybierz wpisujac: Atak-1 leczenie-2 ucieczka-3");
    string turas = Console.ReadLine()!;
    int tura = int.Parse(turas);
    switch (tura)
{
    case 1:
        Console.WriteLine("Zadano obrazenia");
        zdrowiePrzeciwnika -= 12;
        break;
        case 2:
        if(liczbaMikstur > 0)
            {
                zdrowieBohatera += 15;
                Console.WriteLine("Użyto mikstury");
                liczbaMikstur -= 1;
                
            }
            else
            {
                Console.WriteLine("Brak mikstur");
            }
            break;
        case 3:

        
    default:
        Console.WriteLine("nie śpij");
        break;
}
Console.WriteLine("Przeciwnik oddał atak");
zdrowieBohatera -= 6;
}
Console.WriteLine("koniec walki");