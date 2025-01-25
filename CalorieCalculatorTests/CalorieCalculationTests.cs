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
        /// CorrectCalories�̃e�X�g�f�[�^
        /// </summary>
        public static TheoryData<double, double, double, long> CorrectCaloriesData =>
            new TheoryData<double, double, double, long>
            {
                // �v�Z���������s���Ă��邩
                { 2.5, 0.3, 37.1, 161 },
                { 16.5, 10.0, 12.1, 204 },
                // Protein�̎l�̌ܓ��e�X�g
                { 0.64, 0.0, 0.0, 2 },
                { 0.65, 0.0, 0.0, 3 },
                // Fat�̎l�̌ܓ��e�X�g+���ʂ̎l�̌ܓ��e�X�g
                { 0.0, 0.54, 0.0, 5 },
                { 0.0, 0.55, 0.0, 5 },
                // Carbonydrate�̎l�̌ܓ��e�X�g
                { 0.0, 0.0, 0.64, 2 },
                { 0.0, 0.0, 0.65, 3 },
                // TODO: �ő�l�ƍŏ��l�̗v�����s���Ȃ̂Ŕ���������e�X�g��ǉ�����
                // �ŏ��l�̃e�X�g�i0�ȉ��͂Ȃ��O��j
                { 0.0, 0.0, 0.0, 0 },
                // �ő�l�̃e�X�g�i����7�����ő�Ƃ���j
                { 9999999.9, 9999999.9, 9999999.9, 169999999 }

            };
    }
}