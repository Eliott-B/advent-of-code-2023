using System;
namespace AdventOfCode2023.Day
{
	public static class Day3
	{
		public static int Step1(string szInputPath)
        {
			int iResult = 0;

            string szText = File.ReadAllText(szInputPath);
            string[] szLines = szText.Split("\n");
			char[][] szInput = new char[szLines.Length][];
			for (int iIndex = 0; iIndex < szLines.Length; iIndex++)
			{
				szInput[iIndex] = szLines[iIndex].ToCharArray();
			}

			for (int i = 0; i < szInput.Length; i++)
			{
				int j = 0;
				while (j < szInput[i].Length)
				{
					if (szInput[i][j] > 47 &&
						szInput[i][j] < 58)
					{
						bool bSymbol = false;
						string szInt = szInput[i][j].ToString();
						if (((szInput[i][(j + 1)%(szInput[i].Length-1)] > 47 && szInput[i][(j + 1) % (szInput[i].Length-1)] < 58) == false && szInput[i][(j + 1) % (szInput[i].Length-1)] != '.') ||
                            ((szInput[i][Math.Abs(j - 1)] > 47 && szInput[i][Math.Abs(j - 1)] < 58) == false && szInput[i][Math.Abs(j - 1)] != '.') ||
                            ((szInput[(i + 1) % (szInput.Length-1)][j] > 47 && szInput[(i + 1) % (szInput.Length-1)][j] < 58) == false && szInput[(i + 1) % (szInput.Length-1)][j] != '.') ||
                            ((szInput[Math.Abs(i - 1)][j] > 47 && szInput[Math.Abs(i - 1)][j] < 58) == false && szInput[Math.Abs(i - 1)][j] != '.') ||
                            ((szInput[(i + 1) % (szInput.Length-1)][Math.Abs(j - 1)] > 47 && szInput[(i + 1) % (szInput.Length-1)][Math.Abs(j - 1)] < 58) == false && szInput[(i + 1) % (szInput.Length-1)][Math.Abs(j - 1)] != '.') ||
                            ((szInput[(i + 1) % (szInput.Length-1)][(j + 1) % (szInput[i].Length-1)] > 47 && szInput[(i + 1) % (szInput.Length-1)][(j + 1) % (szInput[i].Length-1)] < 58) == false && szInput[(i + 1) % (szInput.Length-1)][(j + 1) % (szInput[i].Length-1)] != '.') ||
                            ((szInput[Math.Abs(i - 1)][Math.Abs(j - 1)] > 47 && szInput[Math.Abs(i - 1)][Math.Abs(j - 1)] < 58) == false && szInput[Math.Abs(i - 1)][Math.Abs(j - 1)] != '.') ||
                            ((szInput[Math.Abs(i - 1)][(j + 1) % (szInput[i].Length-1)] > 47 && szInput[Math.Abs(i - 1)][(j + 1) % (szInput[i].Length-1)] < 58) == false && szInput[Math.Abs(i - 1)][(j + 1) % (szInput[i].Length-1)] != '.'))
						{
							bSymbol = true;
						}

                        while (j < szInput[i].Length - 1 &&
							szInput[i][j + 1] > 47 &&
							szInput[i][j + 1] < 58)
                        {
                            j++;
                            szInt += szInput[i][j].ToString();
                            if (((szInput[i][(j + 1) % (szInput[i].Length-1)] > 47 && szInput[i][(j + 1) % (szInput[i].Length-1)] < 58) == false && szInput[i][(j + 1) % (szInput[i].Length-1)] != '.') ||
                                ((szInput[i][Math.Abs(j - 1)] > 47 && szInput[i][Math.Abs(j - 1)] < 58) == false && szInput[i][Math.Abs(j - 1)] != '.') ||
                                ((szInput[(i + 1) % (szInput.Length-1)][j] > 47 && szInput[(i + 1) % (szInput.Length-1)][j] < 58) == false && szInput[(i + 1) % (szInput.Length-1)][j] != '.') ||
                                ((szInput[(i + 1) % (szInput.Length-1)][Math.Abs(j - 1)] > 47 && szInput[(i + 1) % (szInput.Length-1)][Math.Abs(j - 1)] < 58) == false && szInput[(i + 1) % (szInput.Length-1)][Math.Abs(j - 1)] != '.') ||
                                ((szInput[(i + 1) % (szInput.Length-1)][(j + 1) % (szInput[i].Length-1)] > 47 && szInput[(i + 1) % (szInput.Length-1)][(j + 1) % (szInput[i].Length-1)] < 58) == false && szInput[(i + 1) % (szInput.Length-1)][(j + 1) % (szInput[i].Length-1)] != '.') ||
								((szInput[Math.Abs(i - 1)][(j + 1) % (szInput[i].Length-1)] > 47 && szInput[Math.Abs(i - 1)][(j + 1) % (szInput[i].Length-1)] < 58) == false && szInput[Math.Abs(i - 1)][(j + 1) % (szInput[i].Length-1)] != '.'))
                            {
                                bSymbol = true;
                            }
                        }

						if (bSymbol == true)
						{
							iResult += Int32.Parse(szInt);
						}
                    }
                    j++;
                }
			}
			return iResult;
		}
	}
}

