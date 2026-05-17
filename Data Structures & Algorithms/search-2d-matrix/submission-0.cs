public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int left = 0, right = m * n - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int row = mid / n;
            int col = mid % n;
            int value = matrix[row][col];

            if (value == target)
                return true;
            else if (value < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }
}

/*
    0    1    2    3
0   1    2    4    8
1   10   11   12   13
2   14   20   30   40

15
left  right up    down  mid
0     3     0     2     1,1
0     1     0     1     

*/