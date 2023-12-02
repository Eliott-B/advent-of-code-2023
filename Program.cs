using AdventOfCode2023.day;

string szProjectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

Console.WriteLine("Advent of code 2023");

// DAY 1
string szInputDay1 = szProjectPath + "/input/day1-1";
int iResult = day1.step1(szInputDay1);
Console.WriteLine(iResult);

Console.ReadKey();