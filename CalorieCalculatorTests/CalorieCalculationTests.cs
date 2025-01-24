using CalorieCalculator;

namespace CalorieCalculatorTests
{
    /// <summary>
    /// CalorieCalculationのテスト
    /// </summary>
    public class CalorieCalculationTests
    {
        /// <summary>
        /// カロリー計算が正しいく行えているか
        /// </summary>
        [Theory]
        [MemberData(nameof(CorrectCaloriesData))]
        public void CorrectCalories(double protein, double fat, double carbohydrate, double expected)
        {
            // Arrange
            var amountOfIntake = new AmountOfIntake
            {
                Protein = protein,
                Fat = fat,
                Carbohydrate = carbohydrate
            };
            var calorieCalculation = new CalorieCalculation();

            // Act
            var result = calorieCalculation.Execute(amountOfIntake);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// CorrectCaloriesのテストデータ
        /// </summary>
        public static TheoryData<double, double, double, long> CorrectCaloriesData =>
            new TheoryData<double, double, double, long>
            {
                // 計算が正しく行えているか
                { 2.5, 0.3, 37.1, 161 },
                { 16.5, 10.0, 12.1, 204 },
                // Proteinの四捨五入テスト
                { 0.64, 0.0, 0.0, 2 },
                { 0.65, 0.0, 0.0, 3 },
                // Fatの四捨五入テスト+結果の四捨五入テスト
                { 0.0, 0.54, 0.0, 5 },
                { 0.0, 0.55, 0.0, 5 },
                // Carbonydrateの四捨五入テスト
                { 0.0, 0.0, 0.64, 2 },
                { 0.0, 0.0, 0.65, 3 },
            };
    }
}