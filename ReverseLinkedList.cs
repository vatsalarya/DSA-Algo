public class MyLinkedList<T>
{
    public class Node
    {
        public T Data {get; set;}
        public Node Next {get; set;}

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node Head {get; set;}
    private Node Tail {get; set;}
    private int Length {get; set;}

    public void Append(T data)
    {
        var newNode = new Node(data);
        if(Head == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode; 
        }
        Length++;
    }

    public void Prepend(T data)
    {
        var newNode = new Node(data)
        {
            Next = Head
        };
        Head = newNode;
        if(Tail == null)
        {
            Tail = Head;
        }
        Length++;
    }

    public void Clear(T data)
    {
        Head = null;
        Tail = null;
        Length = 0;
    }

    public void InsertAt(T data, int index)
    {
        if (index <= 0)
        {
            AddFirst(data); // insert at start
            return;
        }

        if (index >= count)
        {
            Append(data);    // insert at end
            return;
        }

        var currentNode = Head;
        for (int i = 0; i < index - 1; i++)
        {
            currentNode = currentNode.Next;
        }

        var newNode = new Node(data)
        {
            Next = currentNode.Next
        };
        currentNode.Next = newNode;

        count++;
    }

    public bool RemoveAt(int index)
    {
        if(index >= Length || index < 0)
        {
            return false;
        }

        if(index == 0)
        {
            Head = Head.Next;
            if(Length == 1)
            {
                Tail = null;
            }
        }
        else
        {
            var currentNode = Head;
            for(int i=0; i<index-1; i++)
            {
                currentNode = currentNode.Next;
            }
            // Remove the target node
            var nodeToRemove = currentNode.Next;
            currentNode.Next = nodeToRemove.Next;

            // If we removed the last node, update Tail
            if (nodeToRemove == Tail)
            {
                Tail = currentNode;
            }
        }
        
        Length --;
        return true;
    }

// Reverse – algorithm practice

    public void Reverse()
    {
        if(Length <= 1)
        {
            return;
        }

        var currentNode = Head;
        var prevNode = null;
        while(currentNode != null)
        {
            var nextNode = currentNode.Next;
            currentNode.Next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
        }
        Tail = Head;
        Head = prevNode;
    }

    public void ReverseRecursive()
    {
        if (Length <= 1)
        {
            return;
        }

        Tail = Head;
        Head = Reverse(Head);
    }

    private Node Reverse(Node current)
    {
        if (current == null || current.Next == null)
        {
            return current;
        }

        var newHead = Reverse(current.Next);

        current.Next.Next = current;
        current.Next = null;

        return newHead;
    }
// IEnumerable – advanced iteration
}