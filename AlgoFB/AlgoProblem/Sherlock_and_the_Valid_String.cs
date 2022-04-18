namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //Correct: https://www.hackerrank.com/rest/contests/master/challenges/sherlock-and-valid-string/hackers/korbinian90/download_solution
        //ref: https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem

        //WRONG
        public static string Sherlock_and_the_Valid_String(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "NO";
            }
            //aabc
            //a[2]
            //b[1]
            //c[1]

            s = s.Trim();
            var found_remove_one = false;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[i + 1])
                {
                    found_remove_one = false;
                }

                if (found_remove_one)
                    return "NO";

                if (s[i] == s[i + 1])
                    found_remove_one = true;
            }

            return "YES";
        }
    }
}