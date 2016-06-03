using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 男性

            // 太瘦
            testBMICalculator(170, 55, GenderEnum.Male);
            // 太胖
            testBMICalculator(170, 80, GenderEnum.Male);
            // 適中
            testBMICalculator(170, 70, GenderEnum.Male);

            #endregion 男性

            #region 女性

            // 太瘦
            testBMICalculator(170, 50, GenderEnum.Female);
            // 太胖
            testBMICalculator(170, 70, GenderEnum.Female);
            // 適中
            testBMICalculator(170, 60, GenderEnum.Female);

            #endregion 女性
        }

        private static void testBMICalculator(double height, double weight, GenderEnum gender)
        {
            var people = new Human()
            {
                Height = height,
                Weight = weight,
                Gender = gender
            };

            var bmiCalculator = new BMICalculator();
            bmiCalculator.People = people;

            showResult(bmiCalculator);
        }

        private static void showResult(BMICalculator bmiCalculator)
        {
            Console.WriteLine($"身高：{bmiCalculator.People.Height}");
            Console.WriteLine($"體重：{bmiCalculator.People.Weight}");
            Console.WriteLine($"性別：{bmiCalculator.People.Gender}");
            Console.WriteLine($"BMI：{bmiCalculator.CalculateHealthScore().ToString("0.00")}");
            Console.WriteLine($"診斷結果：{bmiCalculator.GetHealthAdvise()}");
            Console.WriteLine("===================");
        }
    }
}