namespace CalorieCalculator
{
    /// <summary>
    /// カロリー計算
    /// </summary>
    public class CalorieCalculation : ICalorieCalculation
    {
        /// <summary>
        /// タンパク質の1gあたりのカロリー
        /// </summary>
        private const int ProteinCaloriesPerGram = 4;

        /// <summary>
        /// 脂肪の1gあたりのカロリー
        /// </summary>
        private const int FatCaloriesPerGram = 9;

        /// <summary>
        /// 炭水化物の1gあたりのカロリー
        /// </summary>
        private const int CarbohydrateCaloriesPerGram = 4;

        /// <summary>
        /// カロリー計算を実行します
        /// </summary>
        /// <param name="amountOfIntake">摂取量</param>
        /// <returns>三大栄養素の摂取量から計算したカロリー</returns>
        public long Execute(AmountOfIntake amountOfIntake)
        {
            var protein = Math.Round(amountOfIntake.Protein, 1, MidpointRounding.AwayFromZero);
            var fat = Math.Round(amountOfIntake.Fat, 1, MidpointRounding.AwayFromZero);
            var carbohydrate = Math.Round(amountOfIntake.Carbohydrate, 1, MidpointRounding.AwayFromZero);

            return (long)Math.Round(
                (protein * ProteinCaloriesPerGram) +
                (fat * FatCaloriesPerGram) +
                (carbohydrate * CarbohydrateCaloriesPerGram), 0, MidpointRounding.AwayFromZero);
        }
    }
}
