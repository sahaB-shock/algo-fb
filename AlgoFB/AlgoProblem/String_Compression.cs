using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo 
    {
        //aa  bb && 1
        public static string String_Compression(string data)
        {
            if (data == null || data.Length == 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            int sum = 1;
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] == data[i + 1])
                {
                    sum++;
                }
                else
                {
                    sb.Append(data[i]);
                    sb.Append(sum);
                    sum = 1;
                }
            }

            sb.Append(data[data.Length - 1]);
            sb.Append(sum);

            return sb.ToString();
        }


        public static string String_Compression_Single_Space(string data)
        {
            if (string.IsNullOrEmpty(data))
                return string.Empty;
            data = data.Trim();//Any spaces in prefix & suffix - Remove em
            StringBuilder sb = new StringBuilder();
            int sum = 1;
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] != ' ')
                {
                    if (data[i] == data[i + 1])
                    {
                        sum++;
                    }
                    else
                    {
                        sb.Append(data[i]);
                        if (sum != 1)
                        {
                            sb.Append(sum);
                        }
                        sum = 1;
                    }
                }
                else
                {
                    if (i != 0 && data[i - 1] != ' ')
                        sb.Append(' ');
                }
            }

            if (!string.IsNullOrEmpty(data))
            {
                sb.Append(data[data.Length - 1]);
                if (sum != 1)
                {
                    sb.Append(sum);
                } 
            }

            return sb.ToString();
        }
    }
}
