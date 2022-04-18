using System.Collections.Generic;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static List<int> Add_One_To_Array_Last_Element_Number(List<int> A)
        {
            // 9 9 9 9 9
            // 0 1 2 3 4
            //Add 1 at 4 index and carry forward to left ← right
            /*int carry = 0;

            for (int j = A.Count - 1; j >= 0; j--)
            {
                int sum = 0;
                if (j == A.Count - 1)
                {
                    sum = A[j] + 1;//j = 4 → 10
                }
                else
                {
                    sum = A[j] + carry;
                }
                if (sum >= 10)
                {
                    carry = 1;
                    sum %= 10;
                    //sum = sum % 10;
                }
                A[j] = sum;
            }
            A.Insert(0, 1);
            return A;*/



            // 9 9 9 9 9
            // 0 1 2 3 4
            //Add 1 at 4 index and carry forward to left ← right
            int carry = 1;
            int sum = 0;
            for (int j = A.Count - 1; j >= 0; j--)
            {
                sum = A[j] + carry;
                if (sum >= 10)
                    carry = 1;
                else
                    carry = 0;

                sum = sum % 10;
                A[j] = sum;
            }
            if (carry == 1)
                A.Insert(0, 1);
            //A.RemoveAt(0)
            return A;
        }
    }
}