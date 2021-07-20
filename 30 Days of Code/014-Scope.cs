    public Difference(int[] a)
    {
        this.elements = a;
    }

    public void computeDifference()
    {
        int maxValue = elements.Max();
        int minValue = elements.Min();

        maximumDifference = maxValue - minValue;
    }
