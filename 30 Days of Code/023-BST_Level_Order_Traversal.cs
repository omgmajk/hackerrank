static void levelOrder(Node root)
{
    Queue myQue = new Queue();
    myQue.Enqueue(root);

    while(myQue.Count > 0)
    {
        Node cur = (Node) myQue.Peek();
        if (cur.left != null)
            myQue.Enqueue(cur.left);
        if (cur.right != null)
            myQue.Enqueue(cur.right);

        Console.Write($"{cur.data} ");
        myQue.Dequeue();
    }
}
