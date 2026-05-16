public class Solution {
    public bool IsValid(string s) {
        Stack<char> p_stack = new Stack<char>();
        Dictionary<char, char> p_dict = new Dictionary<char, char>{
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        for(int i=0; i<s.Length; i++)
        {
            if(s[i]=='(' || s[i]=='{' || s[i]=='[')
            {
                p_stack.Push(s[i]);
            }
            else if(p_dict.ContainsKey(s[i]))
            {
                if(p_stack.Count==0 || p_stack.Peek()!=p_dict[s[i]])
                {
                    return false;
                }
                else
                {
                    p_stack.Pop();
                }
            }
        }
        return p_stack.Count == 0;
    }
}
