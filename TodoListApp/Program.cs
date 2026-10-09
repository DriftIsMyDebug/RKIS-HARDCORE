using System;

Console.WriteLine("Application developed by: Nozdrin VV");
Console.WriteLine("=============================================");


Console.Write("Enter your firstname: ");
string firstName = Console.ReadLine() ?? "";

Console.Write("Enter your lastname: ");
string lastName = Console.ReadLine() ?? "";

Console.Write("Enter your birth year: ");
string birthYearInput = Console.ReadLine() ?? "0";


// converting birth year to int and calculating age

int birthYear = Convert.ToInt32(birthYearInput);
int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;

Console.WriteLine("---------------------------------------------");
Console.WriteLine($"User added: {firstName} {lastName}, age - {age}");