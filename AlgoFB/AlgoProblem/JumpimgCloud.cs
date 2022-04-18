namespace AlgoFB.AlgoProblem
{
    /*
     Emma is playing a new mobile game that starts with consecutively numbered clouds. Some of the clouds are thunderheads and others are cumulus. She can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus  or . She must avoid the thunderheads. Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud. It is always possible to win the game.
    For each game, Emma will get an array of clouds numbered  if they are safe or  if they must be avoided. For example,  indexed from . The number on each cloud is its index in the list so she must avoid the clouds at indexes  and . She could follow the following two paths:  or . The first path takes  jumps while the second takes .
    Function Description

    Complete the jumpingOnClouds function in the editor below. It should return the minimum number of jumps required, as an integer.

    jumpingOnClouds has the following parameter(s):

    c: an array of binary integers

         */

    public static partial class Algo
    {
        public static int JumpingCouldMinimumSteps(int[] c)
        {
            //  →   → →   →
            //0 0 1 0 0 1 0
            //1 2 3 4 5 6 7
            //0 1 2 3 4 5 6

            //next cloud# to jump = current cloud# + (1 || 2)
            //1st step → 0+1 √
            //2nd Step → 0+2 √
            //3rd Step → 0+3 x
            //Emmu can jumps at max 2 steps and min 1 steps.

            //So we try to jump first 2 steps, if that is thunderbold(1), come back to 1 steps. Try yo jump 2 steps, as this way could be minimum jumps
            //if 1 step is also thunderbold(1), then solution doesn't satify. Becuase, Problem said, THERE IS ALWAYS A WIN PATH/JUMPS.
            ///    → →   →
            ///0 1 0 0 1 0
            ///1 2 3 4 5 6

            ///  →   →
            ///0 0 1 1 0 0
            ///1 2 3 4 5 6
            // So two 1 or thunderbold cannot be adjuscent

            //0 0 √ last is 0, 1 jumps
            //1 2

            //    →  x not possible
            //0 1 0 1
            int minSteps = 0;

            int currentPosition = 0;
            int lastPosition = c.Length - 1;
            while (currentPosition < lastPosition)
            {
                if (currentPosition + 1 == lastPosition)
                    currentPosition++;
                else if (c[currentPosition + 2] == 0)
                    currentPosition += 2;
                else//If above 2nd else if doesn't satify, that means currentPostion+1 has a 0
                    currentPosition++;

                minSteps++;
            }

            return minSteps;
        }
    }
}