public class Solution
{
    public int Trap(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int leftMax = 0, rightMax = 0;
        int water = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                {
                    leftMax = height[left];
                }
                else
                {
                    water += leftMax - height[left];
                }
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    water += rightMax - height[right];
                }
                right--;
            }
        }

        return water;
    }
}


/*
i value  high_bar temp_res total_res
0  0      0        0       0
1  2      2        0       0
2  0      2        0+2=2   0
3  3      3        2->0    0->2
4  1      3        2+2=4   2
5  0      3        4+3=7   
6  1
7  3
8  2
9  1







*/