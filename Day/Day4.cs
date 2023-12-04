using System;
namespace AdventOfCode2023.Day
{
	public static class Day4
	{
		public static int Step1(string szInputPath)
        {
            int iResult = 0;

            string szText = File.ReadAllText(szInputPath);
            string[] szGames = szText.Split("\n");

			foreach (string szGame in szGames)
            {
                int iResultGame = 0;

                string[] szWin = szGame.Split(": ")[1].Split(" | ")[0].Split(" ");
                string[] szHand = szGame.Split(": ")[1].Split(" | ")[1].Split(" ");

                int[] iWin = new int[szWin.Length];
                int[] iHand = new int[szHand.Length];
                for (int i = 0; i < szWin.Length; i++)
                {
                    try
                    {
                        iWin[i] = Int32.Parse(szWin[i]);
                    }
                    catch
                    {
                    }
                }
                for (int i = 0; i < szHand.Length; i++)
                {
                    try
                    {
                        iHand[i] = Int32.Parse(szHand[i]);
                    }
                    catch
                    {
                    }
                }

                bool bFirst = true;
                foreach (int iValue in iHand)
                {
                    if (iWin.Contains(iValue) == true &&
                        iValue != 0)
                    {
                        if (bFirst == true)
                        {
                            iResultGame += 1;
                            bFirst = false;
                        }
                        else
                        {
                            iResultGame *= 2;
                        }
                    }
                }

                iResult += iResultGame;
            }

            return iResult;
		}
	}
}

