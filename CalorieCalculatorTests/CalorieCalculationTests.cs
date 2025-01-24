using CalorieCalculator;

namespace CalorieCalculatorTests
{
    /// <summary>
    /// CalorieCalculation�̃e�X�g
    /// </summary>
    public class CalorieCalculationTests
    {
        /// <summary>
        /// �J�����[�v�Z�����������s���Ă��邩
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
        /// CorrectCalories�̃e�X�g�f�[�^
        /// </summary>
        public static TheoryData<double, double, double, long> CorrectCaloriesData =>
            new TheoryData<double, double, double, long>
            {
                /// �ʏ�P�[�X
                { 2.5, 0.3, 37.1, 161 },
            };
    }
}