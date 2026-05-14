public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> unique_nums = new HashSet<int>(nums);
        
        HashSet<int> traced_nums = new HashSet<int>();
        int max_count = 0;
        foreach(int num in nums)
        {
            if(traced_nums.Contains(num))
            {
                continue;
            }
            int count=0;
            for(int i=num; true ;i++)
            {
                if(unique_nums.Contains(i))
                {
                    traced_nums.Add(i);
                    count++;
                }
                else
                {
                    break;
                }
            }
            max_count = Math.Max(max_count, count);
        }
        return max_count;
    }
}
