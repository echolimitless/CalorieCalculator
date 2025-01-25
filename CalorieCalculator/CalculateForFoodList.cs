namespace CalorieCalculator
{
    /// <summary>
    /// 食品リストのカロリー計算
    /// </summary>
    public class CalculateForFoodList : ICalculateForFoodList
    {
        private readonly ICalculateProteinCalories calculateProteinCalories;
        private readonly ICalculateFatCalories calculateFatCalories;
        private readonly ICalculateCarbohydrateCalories calculateCarbohydrateCalories;

        public CalculateForFoodList()
        {
            this.calculateProteinCalories = new CalculateProteinCalories();
            this.calculateFatCalories = new CalculateFatCalories();
            this.calculateCarbohydrateCalories = new CalculateCarbohydrateCalories();
        }

        /// <summary>
        /// 食品リストのカロリー計算を実行します
        /// </summary>
        /// <param name="foodList">食品リスト</param>
        /// <returns>食品リストから計算したカロリー</returns>
        public long Execute(FoodList foodList)
        {
            var proteinCalories = foodList.AmountOfIntakeList.Sum(
                amountOfIntake => calculateProteinCalories.Execute(amountOfIntake.Protein));
            var fatCalories = foodList.AmountOfIntakeList.Sum(
                amountOfIntake => calculateFatCalories.Execute(amountOfIntake.Fat));
            var carbohydrateCalories = foodList.AmountOfIntakeList.Sum(
                amountOfIntake => calculateCarbohydrateCalories.Execute(amountOfIntake.Carbohydrate));

            return proteinCalories + fatCalories + carbohydrateCalories;
        }
    }
}
