using System;
namespace AdventOfCode2023.day
{
	public static class day1
	{
		public static int step1(string szInputPath)
		{
			string szInput = File.ReadAllText(szInputPath);
			string[] szLines = szInput.Split("\n");
			List<List<string>> szNumber = new List<List<string>>();
			int iIndex = 0;
			foreach (string szLine in szLines)
			{
				bool bFirst = true;
				foreach (char szChar in szLine)
				{
					if (szChar >= 48 &&
						szChar <= 57)
					{
                        if (bFirst == true)
                        {
							szNumber.Add(new List<string>());
                            szNumber[iIndex].Add(szChar.ToString());
                            szNumber[iIndex].Add(szChar.ToString());
                            bFirst = false;
                        }
                        else
                        {
                            szNumber[iIndex][1] = szChar.ToString();
                        }
                    }
				}
				iIndex++;
            }

			int iSum = 0;
			foreach (List<string> szChars in szNumber)
			{
				iSum += Int32.Parse(szChars[0] + szChars[1]);
			}

			return iSum;
        }
    }
}
