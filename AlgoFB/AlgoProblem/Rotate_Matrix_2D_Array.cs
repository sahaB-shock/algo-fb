using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        public static int[,] RotateMatrix()
        {
            //Ref: https://stackoverflow.com/questions/42519/how-do-you-rotate-a-two-dimensional-array
            //Ref: https://stackoverflow.com/questions/42519/how-do-you-rotate-a-two-dimensional-array/26374543#26374543
            //Onion Layer            
            /* Extra Matrix Space
             int[,] array = new int[4,4] {
                    { 1,2,3,4 },
                    { 5,6,7,8 },
                    { 9,0,1,2 },
                    { 3,4,5,6 }
                };

                int[,] rotated = RotateMatrix(array, 4);

                static int[,] RotateMatrix(int[,] matrix, int n) {
                    int[,] ret = new int[n, n];

                    for (int i = 0; i < n; ++i) {
                        for (int j = 0; j < n; ++j) {
                            ret[i, j] = matrix[n - j - 1, i];
                        }
                    }

                    return ret;
                }
             */
            #region Explanation
            /*
            I’d like to add a little more detail. In this answer, key concepts are repeated, the pace is slow and intentionally repetitive. The solution provided here is not the most syntactically compact, it is however, intended for those who wish to learn what matrix rotation is and the resulting implementation.

            Firstly, what is a matrix? For the purposes of this answer, a matrix is just a grid where the width and height are the same. Note, the width and height of a matrix can be different, but for simplicity, this tutorial considers only matrices with equal width and height (square matrices). And yes, matrices is the plural of matrix.

            Example matrices are: 2×2, 3×3 or 5×5. Or, more generally, N×N. A 2×2 matrix will have 4 squares because 2×2=4. A 5×5 matrix will have 25 squares because 5×5=25. Each square is called an element or entry. We’ll represent each element with a period (.) in the diagrams below:

            2×2 matrix

            . .
            . .
            3×3 matrix

            . . .
            . . .
            . . .
            4×4 matrix

            . . . .
            . . . .
            . . . .
            . . . .
            So, what does it mean to rotate a matrix? Let’s take a 2×2 matrix and put some numbers in each element so the rotation can be observed:

            0 1
            2 3
            Rotating this by 90 degrees gives us:

            2 0
            3 1
            We literally turned the whole matrix once to the right just like turning the steering wheel of a car. It may help to think of “tipping” the matrix onto its right side. We want to write a function, in Python, that takes a matrix and rotates in once to the right. The function signature will be:

            def rotate(matrix):
                # Algorithm goes here.
            The matrix will be defined using a two-dimensional array:

            matrix = [
                [0,1],
                [2,3]
            ]
            Therefore the first index position accesses the row. The second index position accesses the column:

            matrix[row][column]
            We’ll define a utility function to print a matrix.

            def print_matrix(matrix):
                for row in matrix:
                    print row
            One method of rotating a matrix is to do it a layer at a time. But what is a layer? Think of an onion. Just like the layers of an onion, as each layer is removed, we move towards the center. Other analogies is a Matryoshka doll or a game of pass-the-parcel.

            The width and height of a matrix dictate the number of layers in that matrix. Let’s use different symbols for each layer:

            A 2×2 matrix has 1 layer

            . .
            . .
            A 3×3 matrix has 2 layers

            . . .
            . x .
            . . .
            A 4×4 matrix has 2 layers

            . . . .
            . x x .
            . x x .
            . . . .
            A 5×5 matrix has 3 layers

            . . . . .
            . x x x .
            . x O x .
            . x x x .
            . . . . .
            A 6×6 matrix has 3 layers

            . . . . . .
            . x x x x .
            . x O O x .
            . x O O x .
            . x x x x .
            . . . . . .
            A 7×7 matrix has 4 layers

            . . . . . . .
            . x x x x x .
            . x O O O x .
            . x O - O x .
            . x O O O x .
            . x x x x x .
            . . . . . . .
            You may notice that incrementing the width and height of a matrix by one, does not always increase the number of layers. Taking the above matrices and tabulating the layers and dimensions, we see the number of layers increases once for every two increments of width and height:

            +-----+--------+
            | N×N | Layers |
            +-----+--------+
            | 1×1 |      1 |
            | 2×2 |      1 |
            | 3×3 |      2 |
            | 4×4 |      2 |
            | 5×5 |      3 |
            | 6×6 |      3 |
            | 7×7 |      4 |
            +-----+--------+
            However, not all layers need rotating. A 1×1 matrix is the same before and after rotation. The central 1×1 layer is always the same before and after rotation no matter how large the overall matrix:

            +-----+--------+------------------+
            | N×N | Layers | Rotatable Layers |
            +-----+--------+------------------+
            | 1×1 |      1 |                0 |
            | 2×2 |      1 |                1 |
            | 3×3 |      2 |                1 |
            | 4×4 |      2 |                2 |
            | 5×5 |      3 |                2 |
            | 6×6 |      3 |                3 |
            | 7×7 |      4 |                3 |
            +-----+--------+------------------+
            Given N×N matrix, how can we programmatically determine the number of layers we need to rotate? If we divide the width or height by two and ignore the remainder we get the following results.

            +-----+--------+------------------+---------+
            | N×N | Layers | Rotatable Layers |   N/2   |
            +-----+--------+------------------+---------+
            | 1×1 |      1 |                0 | 1/2 = 0 |
            | 2×2 |      1 |                1 | 2/2 = 1 |
            | 3×3 |      2 |                1 | 3/2 = 1 |
            | 4×4 |      2 |                2 | 4/2 = 2 |
            | 5×5 |      3 |                2 | 5/2 = 2 |
            | 6×6 |      3 |                3 | 6/2 = 3 |
            | 7×7 |      4 |                3 | 7/2 = 3 |
            +-----+--------+------------------+---------+
            Notice how N/2 matches the number of layers that need to be rotated? Sometimes the number of rotatable layers is one less the total number of layers in the matrix. This occurs when the innermost layer is formed of only one element (i.e. a 1×1 matrix) and therefore need not be rotated. It simply gets ignored.

            We will undoubtedly need this information in our function to rotate a matrix, so let’s add it now:

            def rotate(matrix):
                size = len(matrix)
                # Rotatable layers only.
                layer_count = size / 2
            Now we know what layers are and how to determine the number of layers that actually need rotating, how do we isolate a single layer so we can rotate it? Firstly, we inspect a matrix from the outermost layer, inwards, to the innermost layer. A 5×5 matrix has three layers in total and two layers that need rotating:

            . . . . .
            . x x x .
            . x O x .
            . x x x .
            . . . . .
            Let’s look at columns first. The position of the columns defining the outermost layer, assuming we count from 0, are 0 and 4:

            +--------+-----------+
            | Column | 0 1 2 3 4 |
            +--------+-----------+
            |        | . . . . . |
            |        | . x x x . |
            |        | . x O x . |
            |        | . x x x . |
            |        | . . . . . |
            +--------+-----------+
            0 and 4 are also the positions of the rows for the outermost layer.

            +-----+-----------+
            | Row |           |
            +-----+-----------+
            |   0 | . . . . . |
            |   1 | . x x x . |
            |   2 | . x O x . |
            |   3 | . x x x . |
            |   4 | . . . . . |
            +-----+-----------+
            This will always be the case since the width and height are the same. Therefore we can define the column and row positions of a layer with just two values (rather than four).

            Moving inwards to the second layer, the position of the columns are 1 and 3. And, yes, you guessed it, it’s the same for rows. It’s important to understand we had to both increment and decrement the row and column positions when moving inwards to the next layer.

            +-----------+---------+---------+---------+
            |   Layer   |  Rows   | Columns | Rotate? |
            +-----------+---------+---------+---------+
            | Outermost | 0 and 4 | 0 and 4 | Yes     |
            | Inner     | 1 and 3 | 1 and 3 | Yes     |
            | Innermost | 2       | 2       | No      |
            +-----------+---------+---------+---------+
            So, to inspect each layer, we want a loop with both increasing and decreasing counters that represent moving inwards, starting from the outermost layer. We’ll call this our ‘layer loop’.

            def rotate(matrix):
                size = len(matrix)
                layer_count = size / 2

                for layer in range(0, layer_count):
                    first = layer
                    last = size - first - 1
                    print 'Layer %d: first: %d, last: %d' % (layer, first, last)

            # 5x5 matrix
            matrix = [
                [ 0, 1, 2, 3, 4],
                [ 5, 6, 6, 8, 9],
                [10,11,12,13,14],
                [15,16,17,18,19],
                [20,21,22,23,24]
            ]

            rotate(matrix)
            The code above loops through the (row and column) positions of any layers that need rotating.

            Layer 0: first: 0, last: 4
            Layer 1: first: 1, last: 3
            We now have a loop providing the positions of the rows and columns of each layer. The variables first and last identify the index position of the first and last rows and columns. Referring back to our row and column tables:

            +--------+-----------+
            | Column | 0 1 2 3 4 |
            +--------+-----------+
            |        | . . . . . |
            |        | . x x x . |
            |        | . x O x . |
            |        | . x x x . |
            |        | . . . . . |
            +--------+-----------+

            +-----+-----------+
            | Row |           |
            +-----+-----------+
            |   0 | . . . . . |
            |   1 | . x x x . |
            |   2 | . x O x . |
            |   3 | . x x x . |
            |   4 | . . . . . |
            +-----+-----------+
            So we can navigate through the layers of a matrix. Now we need a way of navigating within a layer so we can move elements around that layer. Note, elements never ‘jump’ from one layer to another, but they do move within their respective layers.

            Rotating each element in a layer rotates the entire layer. Rotating all layers in a matrix rotates the entire matrix. This sentence is very important, so please try your best to understand it before moving on.

            Now, we need a way of actually moving elements, i.e. rotate each element, and subsequently the layer, and ultimately the matrix. For simplicity, we’ll revert to a 3x3 matrix — that has one rotatable layer.

            0 1 2
            3 4 5
            6 7 8
            Our layer loop provides the indexes of the first and last columns, as well as first and last rows:

            +-----+-------+
            | Col | 0 1 2 |
            +-----+-------+
            |     | 0 1 2 |
            |     | 3 4 5 |
            |     | 6 7 8 |
            +-----+-------+

            +-----+-------+
            | Row |       |
            +-----+-------+
            |   0 | 0 1 2 |
            |   1 | 3 4 5 |
            |   2 | 6 7 8 |
            +-----+-------+
            Because our matrices are always square, we need just two variables, first and last, since index positions are the same for rows and columns.

            def rotate(matrix):
                size = len(matrix)
                layer_count = size / 2

                # Our layer loop i=0, i=1, i=2
                for layer in range(0, layer_count):

                    first = layer
                    last = size - first - 1

             # We want to move within a layer here.
            The variables first and last can easily be used to reference the four corners of a matrix. This is because the corners themselves can be defined using various permutations of first and last (with no subtraction, addition or offset of those variables):

            +---------------+-------------------+-------------+
            | Corner        | Position          | 3x3 Values  |
            +---------------+-------------------+-------------+
            | top left      | (first, first)    | (0,0)       |
            | top right     | (first, last)     | (0,2)       |
            | bottom right  | (last, last)      | (2,2)       |
            | bottom left   | (last, first)     | (2,0)       |
            +---------------+-------------------+-------------+
            For this reason, we start our rotation at the outer four corners — we’ll rotate those first. Let’s highlight them with *.

            * 1 *
            3 4 5
            * 7 *
            We want to swap each * with the * to the right of it. So let’s go ahead a print out our corners defined using only various permutations of first and last:

            def rotate(matrix):
                size = len(matrix)
                layer_count = size / 2
                for layer in range(0, layer_count):

                    first = layer
                    last = size - first - 1

                    top_left = (first, first)
                    top_right = (first, last)
                    bottom_right = (last, last)
                    bottom_left = (last, first)

                    print 'top_left: %s' % (top_left)
                    print 'top_right: %s' % (top_right)
                    print 'bottom_right: %s' % (bottom_right)
                    print 'bottom_left: %s' % (bottom_left)

            matrix = [
            [0, 1, 2],
            [3, 4, 5],
            [6, 7, 8]
            ]

            rotate(matrix)
            Output should be:

            top_left: (0, 0)
            top_right: (0, 2)
            bottom_right: (2, 2)
            bottom_left: (2, 0)
            Now we could quite easily swap each of the corners from within our layer loop:

            def rotate(matrix):
                size = len(matrix)
                layer_count = size / 2
                for layer in range(0, layer_count):

                    first = layer
                    last = size - first - 1

                    top_left = matrix[first][first]
                    top_right = matrix[first][last]
                    bottom_right = matrix[last][last]
                    bottom_left = matrix[last][first]

                    # bottom_left -> top_left
                    matrix[first][first] = bottom_left
                    # top_left -> top_right
                    matrix[first][last] = top_left
                    # top_right -> bottom_right
                    matrix[last][last] = top_right
                    # bottom_right -> bottom_left
                    matrix[last][first] = bottom_right


            print_matrix(matrix)
            print '---------'
            rotate(matrix)
            print_matrix(matrix)
            Matrix before rotating corners:

            [0, 1, 2]
            [3, 4, 5]
            [6, 7, 8]
            Matrix after rotating corners:

            [6, 1, 0]
            [3, 4, 5]
            [8, 7, 2]
            Great! We have successfully rotated each corner of the matrix. But, we haven’t rotated the elements in the middle of each layer. Clearly we need a way of iterating within a layer.

            The problem is, the only loop in our function so far (our layer loop), moves to the next layer on each iteration. Since our matrix has only one rotatable layer, the layer loop exits after rotating only the corners. Let’s look at what happens with a larger, 5×5 matrix (where two layers need rotating). The function code has been omitted, but it remains the same as above:

            matrix = [
            [0, 1, 2, 3, 4],
            [5, 6, 7, 8, 9],
            [10, 11, 12, 13, 14],
            [15, 16, 17, 18, 19],
            [20, 21, 22, 23, 24]
            ]
            print_matrix(matrix)
            print '--------------------'
            rotate(matrix)
            print_matrix(matrix)
            The output is:

            [20,  1,  2,  3,  0]
            [ 5, 16,  7,  6,  9]
            [10, 11, 12, 13, 14]
            [15, 18, 17,  8, 19]
            [24, 21, 22, 23,  4]
            It shouldn’t be a surprise that the corners of the outermost layer have been rotated, but, you may also notice the corners of the next layer (inwards) have also been rotated. This makes sense. We’ve written code to navigate through layers and also to rotate the corners of each layer. This feels like progress, but unfortunately we must take a step back. It’s just no good moving onto the next layer until the previous (outer) layer has been fully rotated. That is, until each element in the layer has been rotated. Rotating only the corners won’t do!

            Take a deep breath. We need another loop. A nested loop no less. The new, nested loop, will use the first and last variables, plus an offset to navigate within a layer. We’ll call this new loop our ‘element loop’. The element loop will visit each element along the top row, each element down the right side, each element along the bottom row and each element up the left side.

            Moving forwards along the top row requires the column index to be incremented.
            Moving down the right side requires the row index to be incremented.
            Moving backwards along the bottom requires the column index to be decremented.
            Moving up the left side requires the row index to be decremented.
            This sounds complex, but it’s made easy because the number of times we increment and decrement to achieve the above remains the same along all four sides of the matrix. For example:

            Move 1 element across the top row.
            Move 1 element down the right side.
            Move 1 element backwards along the bottom row.
            Move 1 element up the left side.
            This means we can use a single variable in combination with the first and last variables to move within a layer. It may help to note that moving across the top row and down the right side both require incrementing. While moving backwards along the bottom and up the left side both require decrementing.

            def rotate(matrix):
                size = len(matrix)
                layer_count = size / 2

                # Move through layers (i.e. layer loop).
                for layer in range(0, layer_count):

                        first = layer
                        last = size - first - 1

                        # Move within a single layer (i.e. element loop).
                        for element in range(first, last):

                            offset = element - first

                            # 'element' increments column (across right)
                            top_element = (first, element)
                            # 'element' increments row (move down)
                            right_side = (element, last)
                            # 'last-offset' decrements column (across left)
                            bottom = (last, last-offset)
                            # 'last-offset' decrements row (move up)
                            left_side = (last-offset, first)

                            print 'top: %s' % (top)
                            print 'right_side: %s' % (right_side)
                            print 'bottom: %s' % (bottom)
                            print 'left_side: %s' % (left_side)
            Now we simply need to assign the top to the right side, right side to the bottom, bottom to the left side, and left side to the top. Putting this all together we get:

            def rotate(matrix):
                size = len(matrix)
                layer_count = size / 2

                for layer in range(0, layer_count):
                    first = layer
                    last = size - first - 1

                    for element in range(first, last):
                        offset = element - first

                        top = matrix[first][element]
                        right_side = matrix[element][last]
                        bottom = matrix[last][last-offset]
                        left_side = matrix[last-offset][first]

                        matrix[first][element] = left_side
                        matrix[element][last] = top
                        matrix[last][last-offset] = right_side
                        matrix[last-offset][first] = bottom
            Given the matrix:

            0,  1,  2  
            3,  4,  5  
            6,  7,  8 
            Our rotate function results in:

            6,  3,  0  
            7,  4,  1  
            8,  5,  2  
             */
            #endregion

            #region 2D Array GetLength()
            /*
             Two-dimensional length. Here we see a simple example of using GetLength on a two-dimensional array. GetLength receives a rank (0 or 1) and prints the result size.
                Note: The Length property, when used on a 2D array, will return the total number of elements, not just a dimension.

                Here: Length returns 5 * 10 elements, which is 50. Every element is counted in Length.

                int[,] two = new int[5, 10];

                two.GetLength(0) → 5
                two.GetLength(1) → 10
                two.Length       → 50 (5*10)

             */
            #endregion
            /*int[,] matrix = new int[4, 4] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };*/
            int[,] matrix = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            var matrix_size = matrix.GetLength(0);
            var layerCount = matrix_size / 2;//WOW
            for (int layer = 0; layer < layerCount; layer++)
            {
                var first = layer;
                var last = matrix_size - layer - 1;//WOW

                #region Explanation
                /*
                    00     →    03
                    ↑ 11  12               
                    21  22  ↓      
                    30     ←   33                 
                    */

                /*var top_left = matrix[first, first]; // 0,0
                var top_right = matrix[first, last]; // 0,3

                var bottom_left = matrix[last, first];//3,0
                var bottom_right = matrix[last, last];//3,3

                /*matrix[first, last] = top_left;
                matrix[last, last] = top_right;
                matrix[last, first] = bottom_right;
                matrix[first, first] = bottom_left;*/
                #endregion
                Console.WriteLine($"Size({matrix_size}): Layer/first {layer} , Last(size-first-1){last}");

                for (int i = first; i < last; i++)
                {
                    var offset = i - first;

                    var top_left = matrix[first, i]; // 0,0
                    var top_right = matrix[i, last]; // 0,3

                    var bottom_left = matrix[last - offset, first];//3,0
                    var bottom_right = matrix[last, last - offset];//3,3

                    matrix[first, i] = bottom_left;
                    matrix[i, last] = top_left;
                    matrix[last, last - offset] = top_right;
                    matrix[last - offset, first] = bottom_right;

                }


            }


            return matrix;
        }
    }
}
