namespace DemoSolid.LSP
{
    public class WeightAverageGradeCalculator : SimpleAverageGradeCalculator
    {
        public WeightAverageGradeCalculator(string subject, int year, int semester) : base(subject, year, semester)
        {
        }

        public override double Calculate(int[] grades)
        {
            var average = (grades[0] * 2 + grades[1] * 2 + grades[2] * 3 + grades[3] * 3) / 10;

            Console.WriteLine($"Matéria: {Subject} do período {Semester}/{Year} é: {average}");

            return average;
        }
    }
}
