namespace CalorieCalculator
{
    /// <summary>
    /// カロリー計算
    /// </summary>
    public interface ICalorieCalculation
    {
        /// <summary>
        /// カロリー計算を実行します
        /// </summary>
        /// <param name="amountOfIntake">摂取量</param>
        /// <returns>三大栄養素の摂取量から計算したカロリー</returns>
        long Execute(AmountOfIntake amountOfIntake);
    }
}