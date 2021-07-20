public class Calculator
{
    public int power(int n, int p)
    {
        if(n >= 0 && p >= 0)
        {
            return (int)Math.Pow(n, p);
        }
        else
        {
            throw new ArgumentException("n and p should be non-negative");
        }
    }
}
