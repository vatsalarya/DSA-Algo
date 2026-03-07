using System.Collections.Generic;

public class MyQueue {
    Stack<int> PushStack;
    Stack<int> PopStack;

    public MyQueue() {
        PushStack=new Stack<int>();
        PopStack=new Stack<int>();
    }
    
    public void Push(int x) {
        PushStack.Push(x);
    }
    
    public int Pop() {
        if (PopStack.Count == 0)
        {
            while(PushStack.Count > 0)
            {
                PopStack.Push(PushStack.Pop());
            }
        }
        return PopStack.Pop();
    }
    
    public int Peek() {
        if (PopStack.Count == 0)
        {
            while(PushStack.Count > 0)
            {
                PopStack.Push(PushStack.Pop());
            }
        }
        return PopStack.Peek();
    }
    
    public bool Empty() {
        if(PushStack.Count == 0 && PopStack.Count == 0)
        {
            return true;
        }
        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */