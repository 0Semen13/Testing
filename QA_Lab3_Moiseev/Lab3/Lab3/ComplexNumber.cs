namespace Lab3 {
/**
 * @brief Класс комплексного числа
 */
    public class ComplexNumber {
        //! Вещественная часть комплексного числа
        private float realPart;
        /**
         * @brief Свойство property поля realPart
         */
        public float RealPart {
            get {
                return realPart;
            }
            set {
                if (value > 2) {
                    realPart = value;
                }
                else {
                    realPart = 10;
                }
            }
        }

        //! Мнимая часть комплексного числа
        private float imaginaryPart;

        /**
         * @brief Конструктор класа
         */
        public ComplexNumber() {
            realPart = 0;
            imaginaryPart = 0;
        }

        /**
         * @brief Функция инициализации объекта класса ComplexNumber
         * @param[in] realP Вещественная часть комплексного числа
         * @param[in] imaginaryP Мнимая часть комплексного числа
         */
        public void Init(float realP, float imaginaryP) {
            RealPart = realP;
            imaginaryPart = imaginaryP;
        }

        /**
         * @brief Функция чтения введенных данных комплексного числа из терминала
         */
        public void Read() {
            Console.WriteLine("Введите вещественную часть комплексного числа: ");
            float realP = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть комплексного числа: ");
            float imaginaryP = (float)Convert.ToDouble(Console.ReadLine());
            Init(realP, imaginaryP);
        }

        /**
         * @brief Функция вывода данных комплексного числа
         */
        public void Display() {
            Console.WriteLine("Вещественная часть: " + realPart);
            Console.WriteLine("Мнимая часть: " + imaginaryPart);
        }

        /**
         * @brief Функция высчитывания модуля комплексного числа
         * @return Модуль комплексного числа
         * 
         * Данная функция вычисляет значение модуля комплексного числа по формуле: \f$\sqrt{(realPart)^2+(imaginaryPart)^2}\f$.
         * Код функции выглядит следубщим образом:
         * \code
         * public float Modulus() {
         *    float modul = (float)Math.Sqrt((realPart * realPart) + (imaginaryPart * imaginaryPart));
         *    return modul;
         * }
         * \endcode
         * @image html img.jpg
         * @image html img.png
         */
        public float Modulus() {
            float modul = (float)Math.Sqrt((realPart * realPart) + (imaginaryPart * imaginaryPart));
            return modul;
        }

        /**
         * @brief Функция сложения двух комплексных чисел
         * @param[in] numb1 Первое комплексное число
         * @param[in] numb2 Второе комплексное число
         * @return Комплексное число, являющееся суммой двух комплексных чисел, передаваемых в параметрах
         */
        public ComplexNumber Add(ComplexNumber numb1, ComplexNumber numb2) {
            ComplexNumber numb3 = new ComplexNumber();
            numb3.realPart = numb1.realPart + numb2.realPart;
            numb3.imaginaryPart = numb1.imaginaryPart + numb2.imaginaryPart;
            return numb3;
        }
    }
}
