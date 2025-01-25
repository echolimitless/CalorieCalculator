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
        public void CorrectCalories(decimal protein, decimal fat, decimal carbohydrate, decimal expected)
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
        public static TheoryData<decimal, decimal, decimal, long> CorrectCaloriesData =>
            new TheoryData<decimal, decimal, decimal, long>
            {
                // 計算が正しく行えているか
                { 2.5M, 0.3M, 37.1M, 161 },
                { 16.5M, 10.0M, 12.1M, 204 },
                // Proteinの四捨五入テスト
                { 0.64M, 0.0M, 0.0M, 2 },
                { 0.65M, 0.0M, 0.0M, 3 },
                // Fatの四捨五入テスト+結果の四捨五入テスト
                { 0.0M, 0.54M, 0.0M, 5 },
                { 0.0M, 0.55M, 0.0M, 5 },
                // Carbonydrateの四捨五入テスト
                { 0.0M, 0.0M, 0.64M, 2 },
                { 0.0M, 0.0M, 0.65M, 3 },
                // TODO: 最大値と最小値の要件が不明なので判明したらテストを追加する
                // 最小値のテスト（0以下はない前提）
                { 0.0M, 0.0M, 0.0M, 0 },
                // 最大値のテスト（仮に7桁を最大とする）
                { 9999999.9M, 9999999.9M, 9999999.9M, 169999999 }
            };
    }
}