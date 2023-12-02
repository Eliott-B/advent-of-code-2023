using AdventOfCode2023.day;

string szProjectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

Console.WriteLine("Advent of code 2023");

// DAY 1
string szInputPath = szProjectPath + "/input/day1";
// PART 1
//int iResult = Day1.Step1(szInputPath);
//Console.WriteLine(iResult);

// PART 2
int iResult = Day1.Step2(szInputPath);
Console.WriteLine(iResult);

Console.ReadKey();