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
        /// CorrectCalories�̃e�X�g�f�[�^
        /// </summary>
        public static TheoryData<decimal, decimal, decimal, long> CorrectCaloriesData =>
            new TheoryData<decimal, decimal, decimal, long>
            {
                // �v�Z���������s���Ă��邩
                { 2.5M, 0.3M, 37.1M, 161 },
                { 16.5M, 10.0M, 12.1M, 204 },
                // Protein�̎l�̌ܓ��e�X�g
                { 0.64M, 0.0M, 0.0M, 2 },
                { 0.65M, 0.0M, 0.0M, 3 },
                // Fat�̎l�̌ܓ��e�X�g+���ʂ̎l�̌ܓ��e�X�g
                { 0.0M, 0.54M, 0.0M, 5 },
                { 0.0M, 0.55M, 0.0M, 5 },
                // Carbonydrate�̎l�̌ܓ��e�X�g
                { 0.0M, 0.0M, 0.64M, 2 },
                { 0.0M, 0.0M, 0.65M, 3 },
                // TODO: �ő�l�ƍŏ��l�̗v�����s���Ȃ̂Ŕ���������e�X�g��ǉ�����
                // �ŏ��l�̃e�X�g�i0�ȉ��͂Ȃ��O��j
                { 0.0M, 0.0M, 0.0M, 0 },
                // �ő�l�̃e�X�g�i����7�����ő�Ƃ���j
                { 9999999.9M, 9999999.9M, 9999999.9M, 169999999 }
            };
    }
}