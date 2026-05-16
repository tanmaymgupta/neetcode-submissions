public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> eval_stack = new Stack<int>();
        foreach(string str in tokens )
        {
            int num, a, b;
            if(int.TryParse(str, out num))
            {
                eval_stack.Push(num);
            }
            else
            {
                b=eval_stack.Pop();
                a=eval_stack.Pop();
                switch(str)
                {
                    case "+":
                        eval_stack.Push(a + b);
                        break;
                    case "-":
                        eval_stack.Push(a - b);
                        break;
                    case "/":
                        eval_stack.Push(a / b);
                        break;
                    case "*":
                        eval_stack.Push(a * b);
                        break;
                }
            }
        }
        return eval_stack.Pop();
    }
}
