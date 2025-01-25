namespace CalorieCalculator
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var rice = new AmountOfIntake
            {
                Protein = 2.5M,
                Fat = 0.3M,
                Carbohydrate = 37.1M
            };

            var natto = new AmountOfIntake
            {
                Protein = 16.5M,
                Fat = 10.0M,
                Carbohydrate = 12.1M
            };

            var calculateProteinCalories = new CalculateProteinCalories();
            var caluculateFatCalories = new CalculateFatCalories();
            var calculateCarbohydrateCalories = new CalculateCarbohydrateCalories();

            var calories = calculateProteinCalories.Execute(rice.Protein) +
                                caluculateFatCalories.Execute(rice.Fat) +
                                calculateCarbohydrateCalories.Execute(rice.Carbohydrate) +
                                calculateProteinCalories.Execute(natto.Protein) +
                                caluculateFatCalories.Execute(natto.Fat) +
                                calculateCarbohydrateCalories.Execute(natto.Carbohydrate);

            Console.WriteLine($"""納豆ご飯の総カロリー：{calories:N0}（kcal）""");
        }
    }
}
