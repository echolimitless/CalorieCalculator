namespace CalorieCalculator
{
    /// <summary>
    /// 摂取量
    /// </summary>
    public record AmountOfIntake
    {
        public double Protein { get; init; }
        public double Fat { get; init; }
        public double Carbohydrate { get; init; }
    }
}
