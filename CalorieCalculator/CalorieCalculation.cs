namespace CalorieCalculator
{

    public class CalorieCalculation : ICalorieCalculation
    {
        private const int ProteinCaloriesPerGram = 4;
        private const int FatCaloriesPerGram = 9;
        private const int CarbohydrateCaloriesPerGram = 4;

        public long Execute(AmountOfIntake amountOfIntake)
        {
            var protein = Math.Round(amountOfIntake.Protein, 1);
            var fat = Math.Round(amountOfIntake.Fat, 1);
            var carbohydrate = Math.Round(amountOfIntake.Carbohydrate, 1);

            return (long)Math.Round(
                (protein * ProteinCaloriesPerGram) +
                (fat * FatCaloriesPerGram) +
                (carbohydrate * CarbohydrateCaloriesPerGram), 0);
        }
    }
}
