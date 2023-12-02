using AdventOfCode2023.Day;

string szProjectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

Console.WriteLine("Advent of code 2023");

// DAY 1
Console.WriteLine("\nDay 1");
string szInputPath = szProjectPath + "/input/day1";
// PART 1
int iResult = Day1.Step1(szInputPath);
Console.WriteLine(iResult);
// PART 2
iResult = Day1.Step2(szInputPath);
Console.WriteLine(iResult);

// DAY 2
Console.WriteLine("\nDay 2");
szInputPath = szProjectPath + "/input/day2";
//PART 1
iResult = Day2.Step1(szInputPath);
Console.WriteLine(iResult);
// PART 2
iResult = Day2.Step2(szInputPath);
Console.WriteLine(iResult);

Console.ReadKey();