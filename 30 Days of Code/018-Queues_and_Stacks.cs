    public Stack<char> myStack = new Stack<char>();
    public Queue<char> myQueue = new Queue<char>();

    void pushCharacter(char c)
    {
        myStack.Push(c);
    }

    char popCharacter()
    {
        return myStack.Pop();
    }
    void enqueueCharacter(char c)
    {
        myQueue.Enqueue(c);
    }

    char dequeueCharacter()
    {
        return myQueue.Dequeue();
    }
