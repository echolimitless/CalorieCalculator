namespace CalorieCalculator
{
    /// <summary>
    /// 資質のカロリー計算
    /// </summary>
    public class CalculateFatCalories : ICalculateFatCalories
    {
        /// <summary>
        /// 資質の1gあたりのカロリー
        /// </summary>
        private const int FatCaloriesPerGram = 9;

        /// <summary>
        /// 資質のカロリー計算を実行します
        /// </summary>
        /// <param name="fatIntake">資質の摂取量</param>
        /// <returns>資質の摂取量から計算したカロリー</returns>
        public long Execute(decimal fatIntake)
        {
            var fat = Math.Round(fatIntake, 1, MidpointRounding.AwayFromZero);

            return (long)Math.Round(
                (fat * FatCaloriesPerGram), 0, MidpointRounding.AwayFromZero);
        }
    }
}
