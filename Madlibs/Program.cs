using System.Formats.Asn1;
using System.Globalization;
using System.Numerics;

string name;
string age;
string personnummer;

// name = "Viktor" + " Hjalmar" + " Lindhardsen";
Console.WriteLine("Vad heter du");
name = Console.ReadLine();

Console.WriteLine("Hur gammal är du");
age = Console.ReadLine();

Console.WriteLine("Vad är ditt personnummer");
personnummer = Console.ReadLine();

Console.WriteLine($"Tack för att du gav den Chinesiska Lederskapet denna informationen: Ditt namn är {name}, Du är {age} år gtammal och ditt personnummer är {personnummer} ");
Console.ReadLine();
