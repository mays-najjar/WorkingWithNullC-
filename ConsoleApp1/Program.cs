// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
// This is a simple to teach you the types of nullable and where to use them.

Console.WriteLine("Nullabe lesson!");

// Nullable types can be used with value types and reference types.
// 1. Nullable Value Type ?
// Value types are not nullable by default, so we can use Nullable<T> or the shorthand T? to make them nullable.
int? i = null;
bool? found ;
if (i.HasValue)
{
    Console.WriteLine(i.Value);
}

// 2. Nullable Reference Type
// Reference types are nullable by default in C# 8.0, so we want to enable nullable reference types 
// in the project file to get warnings for nullability issues. 
#nullable enable
PersonModel? person = null;
if (person != null)
{
    Console.WriteLine(person.Name);
}
else
{
    Console.WriteLine("Person is null");
}
string? name = null;
Console.WriteLine(name?.Length); // If name is: not null: it returns name.Length ,, is null: it returns null (and avoids a crash!)

// 3. Using null-coalescing operator ??
string? nullableString = null;
string nonNullableString = nullableString ?? "Default Value"; // If nullableString is null, it assigns "Default Value"
Console.WriteLine(nonNullableString);

// 4. Using Null-Coalescing Assignment (??=)
string? anotherNullableString = null;

anotherNullableString ??= "Assigned Value"; // If anotherNullableString is null, it assigns "Assigned Value"

// Null-Forgiving Operator (!) 
Console.WriteLine(anotherNullableString!); // Using ! to assert that anotherNullableString is not null, but be cautious with this!

// Null-Conditional Operator (?.)
PersonModel? person1 = null;
int? length = person1?.Name?.Length;

#nullable disable
string name2 = null; // No warning

#nullable enable
string? anotherName = null; // Compiler gives a warning if you use it unsafely

#nullable restore
string? thirdName = null; // Behavior goes back to project’s setting (enable or disable)


