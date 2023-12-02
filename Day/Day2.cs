using System;
namespace AdventOfCode2023.Day
{
	public static class Day2
	{
		public static int Step1(string szInputPath)
		{
            string szInput = File.ReadAllText(szInputPath);
            string[] szLines = szInput.Split("\n");

			int iGames = 0;

			foreach (string szLine in szLines)
			{
				string[] szGame = szLine.Split(": ");
				string[] szRounds = szGame[1].Split("; ");
				bool bOk = true;
				foreach (string szRound in szRounds)
				{
					string[] szCubes = szRound.Split(", ");
					foreach (string szCube in szCubes)
					{
						int iCube = Int32.Parse(szCube[..2]);
						if ((iCube > 12 && szCube.Contains("red")) ||
							(iCube > 13 && szCube.Contains("green")) ||
							(iCube > 14 && szCube.Contains("blue")))
						{
							bOk = false;
						}
					}
				}
				if (bOk == true)
				{
					iGames += Int32.Parse(szGame[0][4..]);
				}
			}

			return iGames;
        }
	}
}

