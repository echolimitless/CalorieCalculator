namespace CalorieCalculator
{
    /// <summary>
    /// 資質のカロリー計算
    /// </summary>
    public class CalculateCarbohydrateCalories : ICalculateCarbohydrateCalories
    {
        /// <summary>
        /// 炭水化物の1gあたりのカロリー
        /// </summary>
        private const int CarbohydrateCaloriesPerGram = 4;

        /// <summary>
        /// 炭水化物のカロリー計算を実行します
        /// </summary>
        /// <param name="carbohydrateIntake">炭水化物の摂取量</param>
        /// <returns>炭水化物の摂取量から計算したカロリー</returns>
        public long Execute(decimal carbohydrateIntake)
        {
            var carbohydrate = Math.Round(carbohydrateIntake, 1, MidpointRounding.AwayFromZero);

            return (long)Math.Round(
                (carbohydrate * CarbohydrateCaloriesPerGram), 0, MidpointRounding.AwayFromZero);
        }
    }
}
