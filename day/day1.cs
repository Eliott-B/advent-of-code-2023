using System;
using System.Threading;

namespace AdventOfCode2023.day
{
	public static class Day1
	{
		public static int Step1(string szInputPath)
		{
			string szInput = File.ReadAllText(szInputPath);
			string[] szLines = szInput.Split("\n");
			List<List<string>> szNumber = new();
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

        //public static int Step2(string szInputPath)
        //{
        //    string szInput = File.ReadAllText(szInputPath);
        //    string[] szLines = szInput.Split("\n");
        //    List<List<string>> szNumber = new();

        //    List<string> szInt = new() { "one", "two", "three", "four", "five",
        //        "six", "seven", "eight", "nine" };

        //    int iIndex = 0;
        //    foreach (string szLine in szLines)
        //    {
        //        bool bFirst = true;
        //        string szTmp = "";
        //        bool bContains = false;
        //        foreach (char szChar in szLine)
        //        {
        //            if ((szChar >= 48 &&
        //                szChar <= 57))
        //            {
        //                if (bFirst == true)
        //                {
        //                    szNumber.Add(new List<string>());
        //                    szNumber[iIndex].Add(szChar.ToString());
        //                    szNumber[iIndex].Add(szChar.ToString());
        //                    bFirst = false;
        //                }
        //                else
        //                {
        //                    szNumber[iIndex][1] = szChar.ToString();
        //                }
        //                szTmp = "";
        //            }
        //            else
        //            {
        //                szTmp += szChar;
        //                foreach (string szNum in szInt)
        //                {
        //                    if (szNum == szTmp)
        //                    {
        //                        if (bFirst == true)
        //                        {
        //                            szNumber.Add(new List<string>());
        //                            szNumber[iIndex].Add((szInt.IndexOf(szNum) + 1).ToString());
        //                            szNumber[iIndex].Add((szInt.IndexOf(szNum) + 1).ToString());
        //                            bFirst = false;
        //                        }
        //                        else
        //                        {
        //                            szNumber[iIndex][1] = (szInt.IndexOf(szNum) + 1).ToString();
        //                        }
        //                        bContains = false;
        //                        break;
        //                    }
        //                    //else if (szNum.Contains(szTmp))
        //                    else if (szTmp.Length <= szNum.Length &&
        //                        szNum[..szTmp.Length] == szTmp)
        //                    {
        //                        bContains = true;
        //                        break;
        //                    }
        //                }
        //                if (bContains == false)
        //                {
        //                    szTmp = szChar.ToString();
        //                }
        //            }
        //        }
        //        iIndex++;
        //    }

        //    int iSum = 0;
        //    foreach (List<string> szChars in szNumber)
        //    {
        //        iSum += Int32.Parse(szChars[0] + szChars[1]);
        //    }

        //    return iSum;
        //}

        public static int Step2(string szInputPath)
        {
            string szInput = File.ReadAllText(szInputPath);
            string[] szLines = szInput.Split("\n");
            List<List<string>> szNumber = new();

            List<string> szInt = new() { "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine" };

            int iIndex = 0;
            foreach (string szLine in szLines)
            {
                bool bFirst = true;
                int iIndexChar = 0;
                foreach (char szChar in szLine)
                {
                    if ((szChar >= 48 &&
                        szChar <= 57))
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
                    else
                    {
                        foreach (string szNum in szInt)
                        {
                            if (szNum.Length <= szLine[iIndexChar..].Length &&
                                szLine[iIndexChar..(iIndexChar + szNum.Length)] == szNum)
                            {
                                if (bFirst == true)
                                {
                                    szNumber.Add(new List<string>());
                                    szNumber[iIndex].Add((szInt.IndexOf(szNum) + 1).ToString());
                                    szNumber[iIndex].Add((szInt.IndexOf(szNum) + 1).ToString());
                                    bFirst = false;
                                }
                                else
                                {
                                    szNumber[iIndex][1] = (szInt.IndexOf(szNum) + 1).ToString();
                                }
                                break;
                            }
                        }
                    }
                    iIndexChar++;
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
