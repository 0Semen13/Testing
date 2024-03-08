using System;
namespace Lab3 {
    /**
     * @brief Класс проекта с функцией main
     */
    internal class Program {
        /**
         * @brief Функция, являющаяся точкой входа в программу
         */
        public static void Main(string[] args) {
            ComplexNumber firstNumb = new ComplexNumber();
            firstNumb.Read();

            ComplexNumber secondNumb = new ComplexNumber();
            secondNumb.Read();

            Console.WriteLine("\nПервое число: ");
            firstNumb.Display();
            Console.WriteLine("\nВторое число: ");
            secondNumb.Display();

            Console.WriteLine("\nМодуль первого комплексного числа: " + firstNumb.Modulus());
            Console.WriteLine("Модуль второго комплексного числа: " + secondNumb.Modulus());

            ComplexNumber thirdNumb = new ComplexNumber();
            thirdNumb = thirdNumb.Add(firstNumb, secondNumb);
            Console.WriteLine("\nПри сложении комплексных чисел получается число: ");
            thirdNumb.Display();
        }
    }
}