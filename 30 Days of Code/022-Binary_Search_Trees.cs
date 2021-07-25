static int getHeight(Node root)
{
    if (root != null)
    {
        return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
    }
    else return -1;
}
