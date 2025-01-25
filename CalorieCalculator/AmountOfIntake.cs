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
        public decimal Protein { get; init; }

        /// <summary>
        /// 脂肪
        /// </summary>
        public decimal Fat { get; init; }

        /// <summary>
        /// 炭水化物
        /// </summary>
        public decimal Carbohydrate { get; init; }
    }
}
