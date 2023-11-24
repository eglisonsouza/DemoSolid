namespace DemoSolid.LSP
{
    public interface IAverageGradeCalculator
    {
        string Subject { get; set; }
        int Year { get; set; }
        int Semester { get; set; }

        double Calculate(int[] grades);
    }
}
