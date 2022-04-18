using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static int[] Find_Indexes_Of_Two_Item_In_Array_Matches_TargetSum(int[] nums, int target)
        {

            if (nums.Length == 0 || target == 0)
                return new int[] { 0, 0 };

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //2,7,11,15 target is 9 
                //i = 0 then 9-2 = 7;dic[7]=0
                int val = 0;
                //Check the number is already added as complement or not. 
                //If the current number is already added as complement, that means, current elemen index & dictionary index are the positions.
                if (dic.TryGetValue(nums[i], out val))
                {
                    return new int[] { val, i };
                }
                if (!dic.ContainsKey(target - nums[i]))
                {
                    dic.Add(target - nums[i]/*key is the complement*/
                            , i);
                }


            }
            return null;
        }
    }
}
