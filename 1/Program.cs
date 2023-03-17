//poproś użytkownika o podanie imienia
Console.WriteLine("Podaj swoje imię:");
//deklaracja nową zmienną typu tekstowego o nazwie "name"
string name = "";
//odczytamy od użytkownika i zapiszemy od zmiennej imię - zapisz nieznajomy jeśli uzytkownik nie udzieli odpowiedzi
name = Console.ReadLine() ?? "nieznajomy";
//nowa zmienna - powitanie
string greeting = "Witaj " + name + "!";
//wpisz gotowe powitanie
Console.WriteLine(greeting);

