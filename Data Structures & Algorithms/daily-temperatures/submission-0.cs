public class Solution {
    public record TempRecord(int Index, int Temp);

    public int[] DailyTemperatures(int[] temperatures) {
        Stack<TempRecord> t_stack = new Stack<TempRecord>();
        int[] result = new int[temperatures.Length];
        for(int i=0; i<temperatures.Length; i++)
        {
            var tuple = new TempRecord(i,temperatures[i]);
            
            while(t_stack.Count > 0 && t_stack.Peek().Temp < temperatures[i])
            {
                TempRecord old_temp = t_stack.Pop();
                result[old_temp.Index] = i - old_temp.Index;
            }
            t_stack.Push(tuple);
        }

        while(t_stack.Count > 0)
        {
            TempRecord old_temp = t_stack.Pop();
            result[old_temp.Index] = 0;
        }
        return result;
    }
}

/*
30  38  30  36  35  40  28
0   1   2   4   5   6   7

0   30  -> [(30,0)] -> [] 
1   38  -> [(38,1)] -> [1]
2   30  -> [(38,1),(30,2)] -> [1]
3   36  -> [(38,1),(36,3)] -> [1,_,1]
4   35
5   40
6   28
*/