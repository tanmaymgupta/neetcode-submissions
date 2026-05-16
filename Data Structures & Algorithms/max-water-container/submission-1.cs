public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int max_area = 0;

        while (left < right)
        {
            if(heights[left] < heights[right])
            {
                max_area = Math.Max(max_area, heights[left] * (right-left));
                left++;
            }
            else
            {
                max_area = Math.Max(max_area, heights[right] * (right-left));
                right--;
            }

        }
        return max_area;
        
    }
}

/*
1 7 2 5 4 7 3 6
0 1 2 3 4 5 6 7

   0   1   2   3   4   5   6   7
1      1   2   3   4   5   6   7
7  7       14  21  28  35  42  49
2  2           6   8   10  12  14
5                  20  25  30  35
4                      20  24  28
7                          42  49
3                              21
6
*/