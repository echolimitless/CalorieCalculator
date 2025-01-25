namespace CalorieCalculator
{
    /// <summary>
    /// タンパク質のカロリー計算
    /// </summary>
    public class CalculateProteinCalories : ICalculateProteinCalories
    {
        /// <summary>
        /// タンパク質の1gあたりのカロリー
        /// </summary>
        private const int ProteinCaloriesPerGram = 4;

        /// <summary>
        /// タンパク質のカロリー計算を実行します
        /// </summary>
        /// <param name="proteinIntake">タンパク質の摂取量</param>
        /// <returns>タンパク質の摂取量から計算したカロリー</returns>
        public long Execute(decimal proteinIntake)
        {
            var protein = Math.Round(proteinIntake, 1, MidpointRounding.AwayFromZero);

            return (long)Math.Round(
                (protein * ProteinCaloriesPerGram), 0, MidpointRounding.AwayFromZero);
        }
    }
}
