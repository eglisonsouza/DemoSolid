namespace DemoSolid.LSP
{
    public class DefaultYearConsolidateService
    {
        private readonly SimpleAverageGradeCalculator _calculator;

        public DefaultYearConsolidateService(SimpleAverageGradeCalculator averageGradeCalculator)
        {
            _calculator = averageGradeCalculator;
        }

        public void Consolidate()
        {
            _calculator.Calculate(new int[] { 1, 2, 3, 4 });
        }
    }
}
