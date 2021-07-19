class Student : Person
{
    private int[] testScores;

    public Student(string first, string last, int id, int[] scores)
    {
        this.firstName = first;
        this.lastName = last;
        this.id = id;
        this.testScores = scores;
    }

    public char Calculate()
    {
        int result = testScores.Sum() / testScores.Length;
        char grade;

        if (result >= 90 && result <= 100)
            grade = 'O';
        else if (result >= 80 && result < 90)
            grade = 'E';
        else if (result >= 70 && result < 80)
            grade = 'A';
        else if (result >= 55 && result < 70)
            grade = 'P';
        else if (result >= 40 && result < 55)
            grade = 'D';
        else
            grade = 'T';

        return grade;
    }
}
