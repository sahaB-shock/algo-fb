using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    static partial class Algo
    {
        public static int CountValleyVisitCompleted(int stepsCount, string stepsPattern)
        {
            int valleyCount = 0;
            int altitude = 0;
            for (int i = 0; i < stepsCount ; i++)
            {
                if (char.ToUpperInvariant(stepsPattern[i]) == 'U')
                {
                    //Increase altitude when Up U
                    altitude++;
                    if (altitude == 0)
                    {
                        //Increase valley count only if he comes up after visting down(valley) and finish at sea level 0. while going up U
                        //Opposite if we want to count Mountain. to visit mountain "through" he has come down to sea level 0, while coming down D
                        valleyCount++;
                    }
                }
                if (char.ToUpperInvariant(stepsPattern[i]) == 'D')
                {
                    altitude--;
                }
                System.Diagnostics.Debug.WriteLine(stepsPattern[i].ToString() + " - " + altitude);

            }

            /*
             Valley counts  - only someone comes up, U to Sea Level of Altitude is 0
            D - -1
            U - 0 **********
            D - -1
            D - -2
            U - -1
            U - 0 **********
            U - 1
            U - 2
            D - 1
            D - 0
            D - -1

             
             */
            return valleyCount;
        }

        /// <summary>
        /// Counts the mountain visit completed.
        /// </summary>
        /// <param name="steps">The steps.</param>
        /// <param name="stepsPattern">The steps pattern.</param>
        /// <returns></returns>
        public static int CountMountainVisitCompleted(int steps, string stepsPattern)
        {
            int mountainVisited = 0;
            int altitude = 0;

            for (int i = 0; i < steps; i++)
            {
                if (stepsPattern[i] == 'U')
                {
                    altitude++;
                }
                if (stepsPattern[i] == 'D')
                {
                    altitude--;

                    if (altitude == 0)
                    {
                        mountainVisited++;
                    }
                }
                System.Diagnostics.Debug.WriteLine(stepsPattern[i].ToString() + " - " + altitude);

            }
            return mountainVisited;
            /*
             Valley counts  - only someome comes up, U to Sea Level of Altitude is 0
            D - -1
            U - 0
            D - -1
            D - -2
            U - -1
            U - 0
            U - 1
            U - 2
            D - 1
            D - 0*
            D - -1

             
             */
        }
    }
}
