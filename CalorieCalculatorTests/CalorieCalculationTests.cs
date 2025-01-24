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
                /// 通常ケース
                { 2.5, 0.3, 37.1, 161 },
            };
    }
}