using System;
using System.Collections.Generic;

string[] names = { "Micke", "Lena", "Martin", "Johanna", "Kalle", "Anna"};
// string name = "Micke";

names[4] = "Pelle";

// for (int i = 0; i < names.Length; i++)
// {
//   Console.WriteLine(names[i]);
// }

List<string> surnames = new List<string>() {"Bergström", "Persson", "Söderblom"};

surnames.Add("Bengtsson");

// Console.WriteLine(surnames[2]);

// for (int i = 0; i < surnames.Count; i++)
// {
//   Console.WriteLine(surnames[i]);
// }


Random generator = new Random();

int n = generator.Next(names.Length);
int n2 = generator.Next(surnames.Count);

string name = names[n];
string surname = surnames[n2];

Console.WriteLine($"{name} {surname} är en dum en");


// int i = 0;
// while (i < 5)
// {
//   i++;
// }

Console.ReadLine();