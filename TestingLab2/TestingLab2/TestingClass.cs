namespace TestingLab2
{
    public class TestingClass
    {
        public float Decision(float x) {
            float arth = 0; //Накапливаемая сумма, член ряда
            float r = x;  //Член ряда
            int n = 1;  //Показатель степени

            if (x < 1 && x > -1)
            {
                while (Math.Abs(r) > 1e-15)
                {
                    arth += r;  //Сумма
                    n += 2;  //Последующие показатели степени
                    r = r * x * x / (n);  //Последующие члены ряда
                }
                return arth;
            }
            else
            {
                Console.Write("\nНеправильное число! ");
                return -100;
            }
        }

        static void Main() {
        }
    }
}