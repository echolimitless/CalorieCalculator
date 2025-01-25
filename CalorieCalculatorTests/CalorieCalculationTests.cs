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

            var calculateProteinCalories = new CalculateProteinCalories();
            var caluculateFatCalories = new CalculateFatCalories();
            var calculateCarbohydrateCalories = new CalculateCarbohydrateCalories();

            // Act
            var result = calculateProteinCalories.Execute(amountOfIntake.Protein) +
                            caluculateFatCalories.Execute(amountOfIntake.Fat) +
                            calculateCarbohydrateCalories.Execute(amountOfIntake.Carbohydrate);

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
                // TODO: 最大値と最小値の要件が不明なので判明したらテストを追加する
                // 最小値のテスト（0以下はない前提）
                { 0.0, 0.0, 0.0, 0 },
                // 最大値のテスト（仮に7桁を最大とする）
                { 9999999.9, 9999999.9, 9999999.9, 169999999 }

            };
    }
}