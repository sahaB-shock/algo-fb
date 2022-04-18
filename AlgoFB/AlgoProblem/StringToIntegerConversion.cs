using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static int StringToIntegerConversion(string str)
        {
            int val = 0;
            int multiplier = 1;
            int start = 0;
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Trim();
                
                if (!char.IsLetter(str[0]))
                {
                    str = Regex.Replace(str, @"[a-zA-Z\s]", "");
                    if (str[0] == '-')
                    {
                        multiplier = -1;
                        start++;
                    }
                    //2124
                    //2*1000
                    //   1*100
                    //      2*10
                    //        4*1            
                    for (int i = start; i < str.Length; i++)
                    {
                        if (char.IsDigit(str[i]))
                        {
                            var valTemp = (Math.Pow(10, str.Length - (i + 1)) * char.GetNumericValue(str[i]));
                            if (valTemp <= int.MaxValue && valTemp >= int.MinValue)
                            {
                                val +=(int)valTemp;
                            }
                            else {
                                if (multiplier == 1)
                                    val = int.MaxValue;
                                else if (multiplier == -1)
                                    val = int.MinValue;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                }

            }



            return val * multiplier;
        }

    }
}
