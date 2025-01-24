namespace CalorieCalculator
{
    /// <summary>
    /// 摂取量
    /// </summary>
    public record AmountOfIntake
    {
        /// <summary>
        /// タンパク質
        /// </summary>
        public double Protein { get; init; }

        /// <summary>
        /// 脂肪
        /// </summary>
        public double Fat { get; init; }

        /// <summary>
        /// 炭水化物
        /// </summary>
        public double Carbohydrate { get; init; }
    }
}
