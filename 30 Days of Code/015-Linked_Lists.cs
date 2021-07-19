public static Node insert(Node head,int data)
{
    Node myNode = new Node(data);
    if(head == null)
    {
        head = myNode;
    }
    else
    {
        if(head.next == null)
            head.next = myNode;
        else
        {
            Node current = head;
            while(current.next != null)
            {
                current = current.next;
            }
            current.next = myNode;
        }
    }
    return head;
}
