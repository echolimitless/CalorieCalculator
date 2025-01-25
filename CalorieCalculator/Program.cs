namespace CalorieCalculator
{
    public static class Program
    {
        static void Main(string[] args)
        {

            // 問題２の計算データ
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

            var foodList = new FoodList
            {
                Name = "納豆ご飯",
                AmountOfIntakeList = [rice, natto]
            };

            var caluculateforfoodlist = new CalculateForFoodList();

            var calories = caluculateforfoodlist.Execute(foodList);

            Console.WriteLine($"""納豆ご飯の総カロリー：{calories:N0}（kcal）""");
        }
    }
}
