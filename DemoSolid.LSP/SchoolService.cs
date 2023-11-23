namespace DemoSolid.LSP
{
    public class SchoolService
    {
        public void ConsolidateClass()
        {
            var averageGradeCalculator = new SimpleAverageGradeCalculator("Portugues", 2022, 1);

            var defaultYearConsolidateService = new DefaultYearConsolidateService(averageGradeCalculator);

            defaultYearConsolidateService.Consolidate();
        }
    }
}
