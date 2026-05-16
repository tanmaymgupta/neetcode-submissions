public class MinStack {

    Stack<int> num_stack;
    Stack<int> min_stack;
    
    public MinStack() {
        num_stack = new Stack<int>();
        min_stack = new Stack<int>();
    }
    
    public void Push(int val) {
        num_stack.Push(val);
        if(min_stack.Count == 0 || val <= min_stack.Peek())
        {
            min_stack.Push(val);
        }
    }
    
    public void Pop() {
        if(num_stack.Count!=0)
        {
            int val = num_stack.Pop();
            if(min_stack.Count != 0 && val == min_stack.Peek())
            {
                min_stack.Pop();
            }
        }
    }
    
    public int Top() {
        return num_stack.Peek();
    }
    
    public int GetMin() {
         return min_stack.Peek();
    }
}

/*
num 1 2 1 4 5 0
min 1 1 0

num 1 2 1 4 5 
min 1 1

num 1
min 1
*/