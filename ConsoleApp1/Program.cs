// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
int? i = null;
string s = null;
bool? found ;
PersonModel person = null ;
if (s is not null)
{
    Console.WriteLine(s.Length);
}
Console.WriteLine(person?.Name);
