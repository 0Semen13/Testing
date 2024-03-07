using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
    public class ComplexNumber {
        private float realPart;
        public float RealPart {
            get {
                return realPart;
            }
            set {
                if (value > 3) {
                    realPart = value;
                }
            }
        }

        private float imaginaryPart;
        public float ImaginaryPart {
            get { return imaginaryPart; }
            set { imaginaryPart = value; }
        }

        public ComplexNumber() {
            realPart = 0;
            imaginaryPart = 0;
        }

        public void Init(float realP, float imaginaryP) {
            RealPart = realP;
            ImaginaryPart = imaginaryP;
        }

        public void Read() {
            Console.WriteLine("Введите вещественную часть комплексного числа: ");
            float realP = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть комплексного числа: ");
            float imaginaryP = (float)Convert.ToDouble(Console.ReadLine());
            Init(realP, imaginaryP);
        }

        public void Display() {
            Console.WriteLine("Вещественная часть: " + realPart);
            Console.WriteLine("Мнимая часть: " + imaginaryPart);
        }

        public float Modulus() {
            float modul = (realPart * realPart) + (imaginaryPart * imaginaryPart);
            return modul;
        }

        public ComplexNumber Add(ComplexNumber numb1, ComplexNumber numb2) {
            ComplexNumber numb3 = new ComplexNumber();
            numb3.realPart = numb1.realPart + numb2.realPart;
            numb3.imaginaryPart = numb1.imaginaryPart + numb2.imaginaryPart;
            return numb3;
        }
    }
}
