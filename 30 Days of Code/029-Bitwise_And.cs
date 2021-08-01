public static int bitwiseAnd(int n, int k)
{
    int max = 0;
    for(int i = 1; i < n + 1; i++)
    {
        for(int j = 1; j < i; j++)
        {
            int num = i & j;
            if(max < num && num < k)
            {
                max = num;
            }
            if(max == k-1)
                return max;
        }
    }
    return max;
}
