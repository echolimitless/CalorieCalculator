namespace CalorieCalculator
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var rice = new AmountOfIntake
            {
                Protein = 2.5,
                Fat = 0.3,
                Carbohydrate = 37.1
            };

            var natto = new AmountOfIntake
            {
                Protein = 16.5,
                Fat = 10.0,
                Carbohydrate = 12.1
            };

            var calorieCalculation = new CalorieCalculation();
            var calories = calorieCalculation.Execute(rice) + calorieCalculation.Execute(natto);
            Console.WriteLine(calories);
        }
    }
}
