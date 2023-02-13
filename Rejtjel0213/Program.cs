Console.WriteLine("2. feladat:");
Console.WriteLine("\nkérem a kulcsot [HOLD]: ");
string k = Console.ReadLine()!;
string kulcs = string.IsNullOrWhiteSpace(k) ? "HOLD" : k.ToUpper();
Console.WriteLine("\nkérem az üzenetet [Szeretem a csokit]: ");
string u = Console.ReadLine()!;
string uzenet = string.IsNullOrWhiteSpace(u) ? "szeretem a csokit" : u.ToLower();

ADFGVXrejtjel adf = new(@"..\..\..\src\kodtabla.txt", uzenet,kulcs);
Console.WriteLine("5. feladat: Az átalakított üzenet: " + adf.AtalakitottUzenet());
Console.WriteLine($"6. feladat: s->{adf.Betupar('s')} x-> {adf.Betupar('x')}");
Console.WriteLine($"7. feladat: Kódszöveg: {adf.Kodszoveg()}");
Console.WriteLine($"8. feladat: Kódolt üzenet: {adf.KodoltUzenet()}");


