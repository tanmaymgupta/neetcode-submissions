public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        prefix[0]=1;
        for(int i=1; i<nums.Length; i++)
        {
            prefix[i] = prefix[i-1] * nums[i-1];
        }

        int postfix = 1;
        int[] result = new int[nums.Length];
        for(int i=nums.Length-1; i>=0; i--)
        {
            result[i] =  postfix * prefix[i];     
            postfix = postfix * nums[i];
        }
        return result;
    }
}


/* 
1   2   4   6
48  24  12  8

  1   1   2   8
x 48  24  6   1
  48  24  12  8
*/