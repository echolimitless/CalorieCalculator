namespace CalorieCalculator
{
    /// <summary>
    /// 食品リスト
    /// </summary>
    public record FoodList
    {
        /// <summary>
        /// 食品名
        /// </summary>
        public required string Name { get; init; }

        /// <summary>
        /// 摂取量リスト
        /// </summary>
        public required IEnumerable<AmountOfIntake> AmountOfIntakeList { get; init; }
    }
}
